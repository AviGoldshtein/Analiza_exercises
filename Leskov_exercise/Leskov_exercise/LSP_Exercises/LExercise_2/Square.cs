using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_2
{
    internal class Square
    {
        public int Side;
        public Square(int side)
        {
            Side = side;
        }
        public int TestArea()
        {
            return Side * Side;
        }
    }
}
