using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Drill: Tool
    {
        public Drill(string name, int weihgt) : base(name, weihgt) 
        {
            this.Category = "drilling";
        }

        public override void Describe()
        {
            Console.WriteLine($"the tool is called {this.Name}, its weihgt {this.Weight} kilo.");
        }

        public override void Use()
        {
            Console.WriteLine("you have to drill with it");
            this.UseCount++;
        }
    }
}
