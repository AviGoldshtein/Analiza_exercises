using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signal_analizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ThreatDictionary TD = new ThreatDictionary();
            SignalAnalyzer SA = new SignalAnalyzer();

            Signal signal1 = new Signal("Launch attack at dawn.", new DateTime());
            Signal signal2 = new Signal("Meeting at safehouse confirmed.", new DateTime());
            Signal signal3 = new Signal("Drop the package near the target.", new DateTime());

            SA.AddSignal(signal1);
            SA.AddSignal(signal2);
            SA.AddSignal(signal3);

            TD.AddKeyword("attack");
            TD.AddKeyword("target");
            TD.AddKeyword("package");

            List<Signal> dangerousSignals = SA.GetThreats();
            
            foreach (Signal sig in dangerousSignals)
            {
                Console.WriteLine(sig);
            }
            

            //List<string> all = TD.GetAllKeywords();
            //foreach (string word in all)
            //{
            //    Console.WriteLine(word);
            //}

            //TD.IsThreat(signal1.GetCleanMessage());


        }
    }
}
