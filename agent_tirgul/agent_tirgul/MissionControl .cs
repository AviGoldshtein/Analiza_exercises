using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agent_tirgul
{
    internal class MissionControl
    {
        public void AnalyzeReport(Report r)
        {
            if (r.UrgencyLevel >= 4)
            {
                Console.WriteLine("Immediate response required.");
            }
            else if (r.UrgencyLevel == 3)
            {
                Console.WriteLine("High priority. Monitor closely.");
            }
            else
            {
                Console.WriteLine("Routine analysis.");
            }
            
        }

    }
}
