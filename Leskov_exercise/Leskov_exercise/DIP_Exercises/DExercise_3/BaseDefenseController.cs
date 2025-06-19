using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_3
{
    internal class BaseDefenseController
    {
        public IAlert Alert;
        public BaseDefenseController(IAlert alert)
        {
            Alert = alert;
        }
    }
}
