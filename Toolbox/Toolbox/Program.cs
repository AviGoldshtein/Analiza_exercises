using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer h = new Hammer("hammer", 13);
            Drill d = new Drill("drill", 20);
            Saw s = new Saw("sow", 17);
            Wrench w = new Wrench("wrench", 54);
            Screwdriver sc = new Screwdriver("Screwdriver", 40);
            PipeCutter p = new PipeCutter("PipeCutter", 70);
            NailGun n = new NailGun("NailGun", 34);
            WireStripper ws = new WireStripper("WireStripper", 64);

            Tool[] tools = { h, d, s, w, sc, p, n, ws };

            ToolBoxAll allToolsList = new ToolBoxAll();

            foreach (var tool in tools)
            {
                allToolsList.AddTool(tool);
            }

            allToolsList.PrintTools();
            allToolsList.sortByCategory();
            Console.WriteLine("///////////////////////////////////////////////////////////");
            allToolsList.PrintTools();




            //Drill aaa = new Drill("aaaaaa", 50);
            //for (int i = 0; i < 20; i++)
            //{
            //    aaa.Use();
            //    Console.WriteLine(aaa.GetUseCount());
            //}

            //ToolBoxAll TBA = new ToolBoxAll();
            //TBA.AddTool(aaa);







        }
    }
}
