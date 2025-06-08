using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgentDAL agentDAL = new AgentDAL();


            //agentDAL.deleteAgent(2);
            //agentDAL.AddAgent("magal", "shelash", "home", "Missing", 78);

            //agentDAL.UpdateAgentLocation(1, "nimrody");

            //List<Agent> agentsParty = agentDAL.SearchAgentsByCode("eagle");

            agentDAL.AddMissionCount(7, 2);

            List<Agent> agents = agentDAL.GetAllAgents();
            agentDAL.PrintAgentList(agents);

            //Dictionary<string, int> statusN = agentDAL.CountAgentsByStatus();
            //agentDAL.printDictionary(statusN);


        }


    }
}
