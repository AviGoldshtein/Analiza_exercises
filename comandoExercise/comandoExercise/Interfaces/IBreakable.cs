using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Interfaces
{
    internal interface IBreakable
    {
        string CheckStatus();
        int GetMaxHitsAmount(); 
        int GetCurrentHitsAmount(); 
    }
}
