using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise
{
    internal class Commando
    {
        protected string Name;
        protected string CodeName;
        private string[] Tools = {"hammer", "chisel", "rope", "bag", "water" };
        private string Status = "standing";

        public Commando(string name, string codeName)
        {
            this.Name = name;
            this.CodeName = codeName;
        }

        public void Walk()
        {
            Console.WriteLine("the solder is walkung");
            this.Status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine("the solder is Hideing");
            this.Status = "Hideing";
        }

        public virtual void Attack()
        {
            Console.WriteLine($"the solder with the name {this.Name} is Attacking");
        }

        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine($"the name of the solder is {this.Name}.");
            }
            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine($"the code name of the solder is {this.CodeName}.");
            }
            else
            {
                Console.WriteLine("sorry, you are not alloud");
            }
        }
    }
}
