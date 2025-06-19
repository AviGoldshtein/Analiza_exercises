using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_4.Entities
{
    internal class ControlRoom
    {
        public void Launch()
        {
            MissionPlanner planner = new MissionPlanner(new FileLogger(), new IntelligenceService(), new MapService());
            planner.PlanMission("Sector 9");
        }
    }
}
