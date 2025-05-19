using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class NailGun : Tool
    {
        public NailGun(string name, int weihgt) : base(name, weihgt) 
        {
            this.Category = "knoking";
        }

        public override void Describe()
        {
            Console.WriteLine($"the tool is called {this.Name}, its weihgt {this.Weight} kilo.");
        }

        public override void Use()
        {
            Console.WriteLine("you have to NailGun with it");
            this.UseCount++;
        }
    }
}
