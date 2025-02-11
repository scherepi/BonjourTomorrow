using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;

namespace BonjourClasses
{
    public class DataHandler
    {
        public String dataPath;
        public LinkedList<Topic> topicList;
        public DataHandler(String dataPath)
        {
            this.dataPath = dataPath;
            this.topicList = new LinkedList<Topic>();
            try { this.initalizeData(); } catch (FileNotFoundException) { System.Console.WriteLine("Unable to initalize data!"); }
        }
        public void initalizeData() {
            // if the data folder exists, then we wanna go through each topic file and pass it to the constructor!
            if (Directory.Exists(this.dataPath))
            {
                foreach (String file in Directory.GetFiles(this.dataPath))
                {
                    // add to our master topic list the created Topic object, passing the file's name and its contents
                    this.topicList.AddLast(new Topic(file, File.ReadAllText(file)));
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
            String progressFile = this.dataPath + "../progress.json";
            if (File.Exists(progressFile)) {
                return new ProgressHandler(File.ReadAllText(progressFile));
            } else
            {
                throw new Exception("Progress file not found!");
            }
        }
    }
}
