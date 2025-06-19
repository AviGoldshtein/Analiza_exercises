using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.DExercise_1
{
    internal class TestDex1 : Itest
    {
        public void Run()
        {
            FileLogger fileLogger = new FileLogger();
            ConsoleLogger consoleLogger = new ConsoleLogger();

            MissionController missionController = new MissionController(consoleLogger);

            missionController.Logger.Log("This is the massage");
        }
    }
}
