using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent_tirgul
{
    internal class Agent
    {
        public string CodeName;
        private int ClearanceLevel;


        public Agent(string codeName, int clearanceLevel)
        {
            this.CodeName = codeName;
            this.ClearanceLevel = clearanceLevel;
        }

        public void Report()
        {
            Console.WriteLine($"Agent {this.CodeName} reporting. Clearance Level: {this.ClearanceLevel}");
        }

        public int GetClearanceLevel()
        {
            return this.ClearanceLevel;
        }

        public void SetClearanceLevel(int level)
        {
            if (level >= 1 && level <= 5)
            {
                this.ClearanceLevel = level;
            }else
            {
                Console.WriteLine("invalid input");
            }
        } 


    }

    
}
