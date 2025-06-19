using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_3
{
    internal class TestDex3 : Itest
    {
        public void Run()
        {
            DroneDispatchAlert droneDispatchAlert = new DroneDispatchAlert();
            SirenAlert sirenAlert = new SirenAlert();

            BaseDefenseController baseDefenseController = new BaseDefenseController(droneDispatchAlert);
            baseDefenseController.Alert.Alert();
        }
    }
}
