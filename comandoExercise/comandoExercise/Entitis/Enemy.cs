using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise
{
    internal class Enemy
    {
        string Name;
        int Lives = 100;
        bool Status = true;

        public Enemy(string name)
        {
            this.Name = name;
        }

        public void Scream()
        {
            Console.WriteLine("i am an enemy!!!");
        }


    }
}
