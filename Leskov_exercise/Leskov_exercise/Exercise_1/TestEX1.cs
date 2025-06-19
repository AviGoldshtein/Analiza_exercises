using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_1
{
    internal class TestEX1 : Itest
    {
        public void Run()
        {
            Bird bird = new Bird();
            Penguin penguin = new Penguin();
            MakeBirdFly(bird);
        }
        public void MakeBirdFly(ICanFly b)
        {
            b.Fly();
        }
    }
}
