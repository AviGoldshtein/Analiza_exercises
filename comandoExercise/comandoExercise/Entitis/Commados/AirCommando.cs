using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }
        public void Parachut()
        {
            Console.WriteLine("parachuting..");
        }

        public override void Attack()
        {
            Console.WriteLine($"the AirCommando with the name {this.Name} is Attacking");
        }
    }
}
