using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Hammer:Tool
    {
        //private string Name;
        //private int Weight;

        public Hammer(string name, int weihgt) : base(name, weihgt) 
        {
            this.Category = "knoking";
        }

        public override void Describe()
        {
            Console.WriteLine($"the tool is called {this.Name}, its weihgt {this.Weight} kilo.");
        }

        public override void Use()
        {
            Console.WriteLine("you have to knok with it");
            this.UseCount++;
        }
    }
}
