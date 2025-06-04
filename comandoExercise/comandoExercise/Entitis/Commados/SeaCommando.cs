using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        public void Swim()
        {
            Console.WriteLine("swiming..");
        }

        public override void Attack()
        {
            Console.WriteLine($"the SeaCommando with the name {this.Name} is Attacking");
        }
    }
}
