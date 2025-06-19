using Leskov_exercise.DExercise_1;
using Leskov_exercise.DExercise_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_4.Entities
{
    internal class FileLogger : ILoggerX2
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FILE] {message}");
        }
    }
}
