using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signal_analizer
{
    internal class SignalAnalyzer
    {
        private ThreatDictionary threatDictionary;
        private List<Signal> interceptedSignals = new List<Signal>();

        public SignalAnalyzer(ThreatDictionary TD)
        {
            threatDictionary = TD;
        }
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

            List<Signal> dangarousSignals = GetThreats();

            DateTime now = DateTime.Now;
            int hourNow = now.Hour;
            int countSignals = 0;

            foreach (Signal signal in dangarousSignals)
            {
                if (signal.GetTimestamp().Hour == hourNow)
                {
                    countSignals++;
                }
            }
            return countSignals;
        }

        public void PrintSignalList(List<Signal> signalList)
        {
            foreach (Signal signal in signalList)
            {
                Console.WriteLine(signal);
                Console.WriteLine();
            }
        }
    }
}
