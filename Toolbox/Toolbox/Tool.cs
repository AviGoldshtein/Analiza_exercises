using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Tool
    {
        protected string Name;
        protected int Weight;
        protected string Category;
        protected int UseCount = 0;

        public Tool(string name, int weihgt)
        {
            this.Name = name;
            this.Weight = weihgt;
        }

        public virtual void Describe()
        {
            Console.WriteLine($"the tool is called {this.Name}, its weihgt {this.Weight} kilo.");
        }

        public virtual void Use()
        {
            Console.WriteLine("Tool is being used");
        }
        public int GetUseCount()
        {
            return this.UseCount;
        }

        public string GetCategory()
        {
            return this.Category;
        }

    }
}
