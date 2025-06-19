using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_1
{
    internal class FileLogger : ILoggereX1
    {
        public void Log(string massage)
        {
            Console.WriteLine("loging to file");
            Console.WriteLine(massage);
        }
    }
}
