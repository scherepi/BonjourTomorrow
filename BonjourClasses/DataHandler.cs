﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;
using System.Collections;

// TODOs:
// - Code cleanup, remove unnecessary checks (we have error handling for a reason)
// - Add comments
// - Add more error handling
// - Make sure to anchor it somewhere in the program, have it passed between threads

namespace BonjourClasses
{
    public class DataHandler
    {
        public String dataPath; // The path to the data folder
        public LinkedList<Topic> topicList; // The list of Topic objects and the questions they contain.
        public Dictionary<String, Question> questionList; // A dictionary of all questions based on ID, for quick access.
        public ProgressHandler progressHandler;
        public DataHandler(String dataPath)
        {
            this.dataPath = dataPath;
            this.topicList = new LinkedList<Topic>();
            this.questionList = new Dictionary<String, Question>();
            try { this.initalizeData(); } catch (FileNotFoundException) { System.Console.WriteLine("Unable to initalize data!"); }
        }
        public void printDebug()
        {
            Console.WriteLine("Data Path: " + this.dataPath);
            Console.WriteLine("Topic Count: " + this.topicList.Count);
            Console.WriteLine("Progress Handler: " + (this.progressHandler != null ? "Initialized" : "Uninitialized"));
            Console.WriteLine("Topics Loaded: ");
            foreach (Topic t in this.topicList) { Console.WriteLine(t.getName()); }
            Console.WriteLine("Questions Loaded: ");
            int sum = 0;
            foreach (Topic t in this.topicList) { sum += t.getQuestions().Count; }
            Console.WriteLine(sum);
            Console.WriteLine("First question's id: " + this.questionList.First().Key);
        }
        public void initalizeData() {
            // if the data folder exists, then we wanna go through each topic file and pass it to the constructor!
            Console.WriteLine("Trying to read from " + this.dataPath);
            if (Directory.Exists(this.dataPath))
            {
                if (Directory.Exists(this.dataPath + "\\Topics")) { 
                    foreach (String file in Directory.GetFiles(this.dataPath + "\\Topics"))
                    {
                        // add to our master topic list the created Topic object, passing the file's name and its contents
                        Console.WriteLine("Found topic file: " + file);
                        String topicName = file.Substring(file.LastIndexOf("\\") + 1);
                        topicName = topicName.Substring(0, topicName.Length - 4);
                        Topic toBeAdded = new Topic(topicName, File.ReadAllText(file));
                        this.topicList.AddLast(toBeAdded);
                        foreach (Question q in toBeAdded.getQuestions())
                        {
                            this.questionList.Add(q.getID(), q);
                        }
                    }
                }
                else {
                    // uh oh, our topics folder's missing - report this to the program
                    Console.Error.WriteLine("Unable to find topics directory.");
                    throw new FileNotFoundException();
                }
                if (File.Exists(this.dataPath + "\\progressFile.json"))
                {
                    Console.WriteLine("Found progress file at " + this.dataPath + "progressFile.json");
                    // Great, found our progress file. Let's make a new ProgressHandler object with it.
                    this.progressHandler = loadProgress();
                } else
                {
                    Console.Error.WriteLine("Unable to find progress file.");
                    throw new FileNotFoundException();
                }
            }
            else {
                // uh oh, our data's missing - report this to the program
                Console.Error.WriteLine("Unable to find data directory.");
                throw new FileNotFoundException();
            }
        }
        public ProgressHandler loadProgress()
        {
            // Returns a ProgressHandler object with the data loaded from the progress file.
            String progressFile = this.dataPath + "\\progressFile.json";
            Console.WriteLine("Trying to read from " + progressFile);
            if (File.Exists(progressFile)) {
                return new ProgressHandler(this, File.ReadAllText(progressFile));
            } else
            {
                throw new Exception("Progress file not found!");
            }
        }
        public Topic getTopic(String name)
        {
            foreach (Topic topic in this.topicList)
            {
                if (topic.getName() == name)
                {
                    return topic;
                }
            }
            return null;
        }

        public Question getQuestion(String ID) {
            if (this.questionList.ContainsKey(ID))
            {
                return this.questionList[ID];
            }
            return null;
        }

        public Question getQuestionFromText(String text)
            // I hate that I have to write this code, but ListView sucks.
        {
            foreach (Question q in this.questionList.Values)
            {
                if (q.getText() == text)
                {
                    return q;
                }
            }
            return null;
        }

        public List<Question> getAllQuestions() {
            return this.questionList.Values.ToList();
        }

        public List<Question> getQuickQuestions() { 
            List<Question> list = new List<Question>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                //list.Add(this.questionList[rnd.Next(0, this.questionList.Count)]);
                list.Add(this.questionList.ElementAt(rnd.Next(0, this.questionList.Count)).Value);
            }
            return list;
        }

        public void saveProgress(ProgressHandler ph)
        {
            // Write the progress handler's data to the progress file.
            String jsonData = ph.serializeData();
            Console.WriteLine("Writing to file...");
            File.WriteAllText(this.dataPath + "\\progressFile.json", jsonData);
        }
    }
}
