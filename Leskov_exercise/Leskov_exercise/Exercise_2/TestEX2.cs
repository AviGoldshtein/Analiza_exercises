using Leskov_exercise.Exercise_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_2
{
    internal class TestEX2 : Itest
    {
        public void Run()
        {
            Rectangle rectangle = new Rectangle(10, 5);
            Console.WriteLine(rectangle.TestArea());

            Square square = new Square(10);
            Console.WriteLine(square.TestArea());
        }
    }
}
