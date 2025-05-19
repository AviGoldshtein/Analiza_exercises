using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class ToolBoxAll
    {
        private List<Tool> tools = new List<Tool>();

        public void AddTool(Tool tool)
        {
            tools.Add(tool);
        }

        public void sortByCategory()
        {
            tools.Sort((a, b) => a.GetCategory().CompareTo(b.GetCategory()));
        }

        public void PrintTools()
        {
            foreach (var tool in tools)
            {
                tool.Describe();
                tool.Use();
                Console.WriteLine(tool.GetUseCount());
                Console.WriteLine($"/////////////////////////////////////////////category: {tool.GetCategory()}");
                Console.WriteLine();
            }
        }
    }
}
