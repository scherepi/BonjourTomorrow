using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BonjourClasses
{
    public class ProgressHandler
    {
        public DataHandler parent;                              // The DataHandler that created this ProgressHandler.
        public Dictionary<String, (int, int)> topicProgress;    // A dictionary of topics and their progress.
        public Dictionary<String, bool> unlocks;                // A dictionary of unlocks and their status.
        public List<String> completed;                           // A list of answered questions.

        public ProgressHandler(DataHandler parent, String progressFile)
        {
            this.parent = parent;
            // Here's all the big nasty JSON parsing.
            JsonDocument jsonProgress = JsonDocument.Parse(progressFile); // First, we parse the file given to us as a JSON document.
            topicProgress = new Dictionary<String, (int, int)>(); // Init our first dict.
            foreach (JsonProperty topic in jsonProgress.RootElement.GetProperty("topicProgress").EnumerateObject()) // Now, for each topic in the JSON file under the topicProgress tag:
            {
                string topicName = topic.Name;
                int currentProgress = topic.Value.GetProperty("Completed").GetInt32();
                int totalProgress = topic.Value.GetProperty("Total").GetInt32();
                topicProgress.Add(topicName, (currentProgress, totalProgress)); // Add it to our topicProgress dictionary with its name as the key, and its current completed and total questions as the value.
            }

            unlocks = new Dictionary<String, bool>(); // Do basically the same thing for everything under the "unlocks" tag, but much simpler.
            foreach(JsonProperty unlock in jsonProgress.RootElement.GetProperty("unlocks").EnumerateObject())
            {
                unlocks.Add(unlock.Name, unlock.Value.GetBoolean());
            }
            completed = new List<String>(); 
            foreach(JsonProperty id in jsonProgress.RootElement.GetProperty("completed").EnumerateObject())
            {
                completed.Add(id.Value.GetString());
            }
            // And we're done! Everything should be loaded.
        }
        public bool isUnlocked(String unlock)
        {
            // Just gotta check the value.
            return unlocks[unlock];
        }
        public (bool, bool) getACUnlocks()
        {
            return (isUnlocked("Bakery"), isUnlocked("Louvre"));
        }
        public void unlock(String unlock)
        {
            // Just gotta set the value!
            unlocks[unlock] = true;
        }
        public void progressTopic(String topic)
        {
            // First, check if the topic is already completed
            if (topicProgress[topic].Item1 == topicProgress[topic].Item2)
            {
                System.Console.WriteLine("Topic already completed.");
                return;
            }
            // Otherwise, increment the progress by 1
            (int, int) progress = topicProgress[topic];
            topicProgress[topic] = (progress.Item1 + 1, progress.Item2);
        }

        public int getTopicProgress(String topic)
        {
            // Just return the current progress.
            return topicProgress[topic].Item1;
        }   

        public void resetProgress()
        {
            // For testing purposes mostly, this'll wipe all progress.
            var topicKeys = new List<string>(topicProgress.Keys);
            foreach (String topic in topicKeys)
            {
                topicProgress[topic] = (0, topicProgress[topic].Item2); // Wipe all our completed questions back to 0 first.
            }
            var unlockKeys = new List<string>(unlocks.Keys);
            foreach (String unlock in unlockKeys)
            {
                unlocks[unlock] = false; // Then, set all our unlocks back to false.
            }
        }
        public void maxOut()
        {
            // For debugging, maxes out all values
            var topicKeys = new List<string>(topicProgress.Keys);
            foreach (String topic in topicKeys)
            {
                topicProgress[topic] = (topicProgress[topic].Item2, topicProgress[topic].Item2);
            }
            var unlockKeys = new List<string>(unlocks.Keys);
            foreach (String unlock in unlockKeys)
            {
                unlocks[unlock] = true;
            }
        }
        public String serializeData()
        {
            // This is the big thing, once we've finished up we need to be able to pass valid JSON back to the DataHandler to save to the progressFile.
            String finalData = "";
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            finalData += "{\n\t";
            finalData += "\"topicProgress\": {\n";
            // Populate topicProgress object
            foreach (String t in topicProgress.Keys)
            {
                finalData += "\t\t \"" + t + "\": {\n";
                finalData += "\t\t\t\"Completed\": " + topicProgress[t].Item1 + ",\n";
                finalData += "\t\t\t\"Total\": " + topicProgress[t].Item2 + "\n";
                finalData += "\t\t },\n";
            }
            finalData = finalData.Substring(0, finalData.Length - 2) + "\n\t},\n";
            finalData += "\t\"unlocks\": {\n";
            // Populate unlocks object
            foreach (String u in unlocks.Keys)
            {
                Console.WriteLine(u + " is " + unlocks[u]);
                finalData += "\t\t\"" + u + "\": " + unlocks[u].ToString().ToLower() + ",\n";
            }
            // Populate completed object
            finalData = finalData.Substring(0, finalData.Length - 2) + "\n\t},\n";
            finalData += "\t\"completed\": [";
            foreach (String id in completed)
            {
                finalData += "\"" + id + "\", ";
            }
            // Remove the last comma and space, finish the write
            finalData = finalData.Substring(0, finalData.Length - 2) + "]\n}";
            return finalData;
        }
        public void printDebug()
        {
            Console.WriteLine(serializeData());
        }
    }
}
