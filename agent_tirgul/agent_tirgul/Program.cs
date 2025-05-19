using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent_tirgul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent agent = new Agent("in serya", 5);
            Report report = new Report();
            report.UrgencyLevel = 4;
            MissionControl mission = new MissionControl();
            mission.AnalyzeReport(report);
            IntelTools.LogTransmission(agent.CodeName, IntelTools.EncryptMessage("on the way to the missin"));
        }
    }
}
