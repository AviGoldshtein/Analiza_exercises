using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_1
{
    internal class MissionController
    {
        public ILoggereX1 Logger;
        public MissionController(ILoggereX1 logger)
        {
            Logger = logger;
        }
    }
}
