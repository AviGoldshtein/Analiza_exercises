using comandoExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Entitis.Weapons
{
    internal class Stone : NonShootingWeapon
    {
        public Stone(string name, int weghit, string color) : base(name, weghit, color) { }

        

    }
}
