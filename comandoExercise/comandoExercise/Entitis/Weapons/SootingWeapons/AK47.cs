using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Entitis.Weapons.SootingWeapons
{
    internal class AK47 : ShootingWeapon
    {
        public AK47(string name, string manufacturer, int numberOfBalls) : base(name, manufacturer, numberOfBalls) { }
    }
}
