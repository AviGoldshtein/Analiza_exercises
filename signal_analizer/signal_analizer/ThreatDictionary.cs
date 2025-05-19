using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signal_analizer
{
    internal class ThreatDictionary
    {
        private List<string> keywords = new List<string>();

        public void AddKeyword(string keyword)
        {
            this.keywords.Add(keyword);
        }

        public void RemoveKeyword(string keyword)
        {
            this.keywords.Remove(keyword);
        }

        public List<string> GetAllKeywords()
        {
            return this.keywords;
        }

        public bool IsThreat(string message)
        {
            bool threat = false;
            foreach (string keyword in this.keywords)
            {
                if (message.Contains(keyword))
                {
                    threat = true;
                    break;
                }
            }
            return threat;
        }

        public void PrintKeywords()
        {
            foreach (string word in this.keywords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
