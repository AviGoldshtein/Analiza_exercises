using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_1
{
    internal class ConsoleLogger : ILoggereX1
    {
        public void Log(string massage)
        {
            Console.WriteLine("loging to console");
            Console.WriteLine(massage);
        }
    }
}
