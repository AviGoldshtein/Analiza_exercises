using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signal_analizer
{
    internal class Signal
    {
        private string RawMessage;
        private DateTime Timestamp;


        public Signal(string rawMessage, DateTime timestamp)
        {
            this.RawMessage = rawMessage;
            this.Timestamp = timestamp;
        }

        public string GetCleanMessage()
        {
            string removedPunctuation = this.RawMessage.Replace(",", "");
            string removedDots = removedPunctuation.Replace(".", "");
            string loweredMsg = removedDots.ToLower();
            return loweredMsg;
        }

        public bool ContainsWord(string word)
        {
            return this.RawMessage.Contains(word);
        }

        public DateTime GetTimestamp()
        {
            return this.Timestamp;
        }

        public override string ToString()
        {
            return $"message: {this.RawMessage}\n" +
                $"datetime: {this.Timestamp}";
        }
    }
}
