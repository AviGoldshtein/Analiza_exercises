using Leskov_exercise.DExercise_4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_4
{
    internal class TestDex4 : Itest
    {
        public void Run()
        {
            ControlRoom controlRoom = new ControlRoom();
            controlRoom.Launch();
        }
    }
}
