using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_2
{
    internal class MainTest
    {
        Itest Test;
        public MainTest(Itest test)
        {
            Test = test;
        }
        public void RunTest()
        {
            Test.Run();
        }
    }
}
