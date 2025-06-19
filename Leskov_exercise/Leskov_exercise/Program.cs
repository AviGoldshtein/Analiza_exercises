using Leskov_exercise.DExercise_1;
using Leskov_exercise.DExercise_2;
using Leskov_exercise.DExercise_3;
using Leskov_exercise.DExercise_4;
using Leskov_exercise.Exercise_1;
using Leskov_exercise.Exercise_2;
using Leskov_exercise.Exercise_3;
using Leskov_exercise.Exercise_4;
using Leskov_exercise.Exercise_5;
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
            TestLex1 Lex1 = new TestLex1();
            TestLex2 Lex2 = new TestLex2();
            TestLex3 Lex3 = new TestLex3();
            TestLex4 Lex4 = new TestLex4();
            TestLex5 Lex5 = new TestLex5();

            TestDex1 Dex1 = new TestDex1();
            TestDex2 Dex2 = new TestDex2();
            TestDex3 Dex3 = new TestDex3();
            TestDex4 Dex4 = new TestDex4();


            MainTest mainTest = new MainTest(Dex4);
            mainTest.RunTest();
        }
    }
}
