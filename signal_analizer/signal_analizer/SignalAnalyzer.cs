using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signal_analizer
{
    internal class SignalAnalyzer
    {
        private ThreatDictionary threatDictionary = new ThreatDictionary();
        private List<Signal> interceptedSignals = new List<Signal>();

        public void AddSignal(Signal signal)
        {
            this.interceptedSignals.Add(signal);
        }

        public List<Signal> GetThreats()
        {
            List<Signal> dangarousSignals = new List<Signal>();

            foreach (Signal s in this.interceptedSignals)
            {
                if (threatDictionary.IsThreat(s.GetCleanMessage()))
                {
                    dangarousSignals.Add(s);
                }
            }
            return dangarousSignals;
        }

        public int CountThreatsPerHour()
        {
            DateTime now = new DateTime();
            int hourNow = now.Hour;
            int countSignals = 0;

            foreach (Signal signal in interceptedSignals)
            {
                if (signal.GetTimestamp().Hour == hourNow)
                {
                    countSignals++;
                }
            }
            return countSignals;
        }
    }
}
