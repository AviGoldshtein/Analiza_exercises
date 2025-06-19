using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_2
{
    internal class TestDex2 : Itest
    {
        public void Run()
        {
            VoiceAnalyzer voiceAnalyzer = new VoiceAnalyzer();
            ThermalScanner thermalScanner = new ThermalScanner();

            TerroristInterrogationUnit terroristInterrogationUnit = new TerroristInterrogationUnit(voiceAnalyzer);
            bool isHeLying =  terroristInterrogationUnit.LieDetector.IsLying();
            string yesOrNo = isHeLying ? "" : "not ";
            Console.WriteLine($"He is {yesOrNo}lying");
        }
    }
}
