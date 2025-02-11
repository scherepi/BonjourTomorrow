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
        public Dictionary<String, (int, int)> topicProgress;
        public Dictionary<String, bool> unlocks;

        public ProgressHandler(String progressFile) {
            JsonDocument jsonProgress = JsonSerializer.SerializeToDocument(progressFile);
            topicProgress = new Dictionary<String, (int, int)>();
            foreach (JsonElement topic in jsonProgress.RootElement.GetProperty("topicProgress").EnumerateArray())
            {
                topicProgress.Add(topic.Name, (topic.GetProperty.));
            }
        }
    }
}
