using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;

namespace BonjourClasses
{
    public class DataHandler
    {
        public String dataPath;
        public LinkedList<Topic> topicList;
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
    }
}
