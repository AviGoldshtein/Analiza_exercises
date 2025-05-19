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
            SignalAnalyzer SA = new SignalAnalyzer(TD);


            Signal signal1 = new Signal("Launch attack at dawn.", DateTime.Now);
            Signal signal2 = new Signal("Meeting at safehouse confirmed.", DateTime.Now);
            Signal signal3 = new Signal("Drop the package near the target.", DateTime.Now);


            SA.AddSignal(signal1);
            SA.AddSignal(signal2);
            SA.AddSignal(signal3);


            TD.AddKeyword("attack");
            TD.AddKeyword("target");
            TD.AddKeyword("package");

            Console.WriteLine($"the amount of threts that was found in the last hour: {SA.CountThreatsPerHour()}\n");

            List<Signal> dangerousSignals = SA.GetThreats();
            Console.WriteLine("here are all the dengarous threts:\n");

            SA.PrintSignalList(dangerousSignals);




            List<string> allBadWords = TD.GetAllKeywords();
            //foreach (string word in allBadWords)
            //{
            //    Console.WriteLine(word);
            //}
            TD.PrintKeywords();

        }
    }
}
