using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_2
{
    internal class TerroristInterrogationUnit
    {
        public ILieDetector LieDetector;
        public TerroristInterrogationUnit(ILieDetector lieDetector)
        {
            LieDetector = lieDetector;
        }
    }
}
