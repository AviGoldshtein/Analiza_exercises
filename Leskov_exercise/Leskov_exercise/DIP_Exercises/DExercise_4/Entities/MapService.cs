using Leskov_exercise.DExercise_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_4.Entities
{
    internal class MapService : IMapService
    {
        public string LoadMap(string location)
        {
            return $"Loaded terrain map for {location}";
        }
    }
}
