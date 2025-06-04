using comandoExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace comandoExercise.Entitis.Weapons
{
    internal class Knife : NonShootingWeapon
    {
        private string MetalType;
        private string Manufaturer;

        public Knife(string name, int weghit, string color, string manufaturer, string metalType) : base(name, weghit, color)
        {
            this.Manufaturer = manufaturer;
            this.MetalType = metalType;
        }
        public override string ToString()
        {
            return base.ToString() + $", MetalType {MetalType}, Manufaturer {Manufaturer}";
        }


    }
}
