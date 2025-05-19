using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class WireStripper : Tool
    {
        public WireStripper(string name, int weihgt) : base(name, weihgt)
        {
            this.Category = "cutting";
        }

        public override void Describe()
        {
            Console.WriteLine($"the tool is called {this.Name}, its weihgt {this.Weight} kilo.");
        }

        public override void Use()
        {
            Console.WriteLine("you have to WireStripper with it");
            this.UseCount++;
        }
    }
}
