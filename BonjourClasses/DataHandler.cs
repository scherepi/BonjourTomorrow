using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;

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
        public ProgressHandler progressHandler;
        public DataHandler(String dataPath)
        {
            this.dataPath = dataPath;
            this.topicList = new LinkedList<Topic>();
            try { this.initalizeData(); } catch (FileNotFoundException) { System.Console.WriteLine("Unable to initalize data!"); }
        }
        public void printDebug()
        {
            Console.WriteLine("Data Path: " + this.dataPath);
            Console.WriteLine("Topic Count: " + this.topicList.Count);
            Console.WriteLine("Progress Handler: " + (this.progressHandler != null ? "Initialized" : "Uninitialized") );
            Console.WriteLine("Topics Loaded: ");
            foreach (Topic t in this.topicList) { Console.WriteLine(t.getName()); }
            Console.WriteLine("Questions Loaded: ");
            int sum = 0;
            foreach (Topic t in this.topicList) { sum += t.getQuestions().Count; }
            Console.WriteLine(sum);
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
                        this.topicList.AddLast(new Topic(file, File.ReadAllText(file)));
                    }
                }
                else {
                    // uh oh, our topics folder's missing - report this to the program
                    Console.Error.WriteLine("Unable to find topics directory.");
                    throw new FileNotFoundException();
                }
                if (File.Exists(this.dataPath + "progressFile.json"))
                {
                    // Great, found our progress file. Let's make a new ProgressHandler object with it.
                    this.progressHandler = new ProgressHandler(this, File.ReadAllText(this.dataPath + "progressFile.json"));
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
        public List<Question> getQuickQuestions() { 
            int numFromEach = (int)Math.Round((20.0 / this.topicList.Count));
            List<Question> list = new List<Question>();
            Random rnd = new Random();
            foreach (Topic t in this.topicList)
            {
                for (int i = 0; i < numFromEach; i++)
                {
                    Question[] tArray = t.getQuestions().ToArray();
                    list.Add(tArray[rnd.Next(0, t.getQuestions().Count)]);
                }

            }
            return list;
        }
    }
}
