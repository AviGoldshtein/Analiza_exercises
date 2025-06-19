using Leskov_exercise.DExercise_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_4.Entities
{
    internal class MissionPlanner : IMissionPlanner
    {
        private ILoggerX2 logger;
        private IIntelligenceService intelService;
        private IMapService mapService;

        public MissionPlanner(ILoggerX2 logger, IIntelligenceService intelService, IMapService mapService)
        {
            this.logger = logger;
            this.intelService = intelService;
            this.mapService = mapService;
        }

        public void PlanMission(string location)
        {
            Console.WriteLine("MISSION BRIEFING:");
            var intel = intelService.GatherIntel(location);
            var map = mapService.LoadMap(location);
            Console.WriteLine(intel);
            Console.WriteLine(map);
            logger.Log($"Mission planned for {location}");
        }
    }
}
