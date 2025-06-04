using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Entitis.Weapons.SootingWeapons
{
    internal class M16 : ShootingWeapon
    {
        public M16(string name, string manufacturer, int numberOfBalls) : base(name, manufacturer, numberOfBalls) { }
    }
}
