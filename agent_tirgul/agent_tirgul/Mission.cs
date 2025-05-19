using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent_tirgul
{
    internal class Mission
    {
        string MissionName;
        string TargetLocation;
        Agent Agent;

        public void Brief()
        {
            Console.WriteLine($"Mission: {this.MissionName}, Target: {this.TargetLocation}, Agent: {Agent.CodeName}");
        }

        public void AssignedAgent(string codeName, int clearanceLevel)
        {
            Agent = new Agent(codeName, clearanceLevel);
        }



    }
}
