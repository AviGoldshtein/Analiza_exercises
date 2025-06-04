using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Interfaces
{
    internal interface IShootable
    {
        void Shoot();
        int CheckBullits();
        bool CanShoot();
    }
}
