using Leskov_exercise.Exercise_1;
using Leskov_exercise.Exercise_2;
using Leskov_exercise.Exercise_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestEX1 eX1 = new TestEX1();
            TestEX2 eX2 = new TestEX2();
            TestEX3 eX3 = new TestEX3();


            MainTest mainTest = new MainTest(eX3);
            mainTest.RunTest();
        }
    }
}
