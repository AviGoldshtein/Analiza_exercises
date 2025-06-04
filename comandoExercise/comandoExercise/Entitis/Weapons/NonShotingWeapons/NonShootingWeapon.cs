using comandoExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Entitis.Weapons
{
    internal class NonShootingWeapon : IBreakable
    {
        private string Name;
        private int Weghit;
        private string Status = "not broken";
        private int MaxHits = 5;
        private int Hited = 0;
        private string Color;

        public NonShootingWeapon(string name, int weghit, string color)
        {
            this.Name = name;
            this.Weghit = weghit;
            this.Color = color;
        }


        public string CheckStatus()
        {
            return this.Status;
        }
        public int GetMaxHitsAmount()
        {
            return this.MaxHits;
        }
        public int GetCurrentHitsAmount()
        {
            return this.Hited;
        }
        public override string ToString()
        {
            return $"Name {Name}, Weghit {Weghit}, Status {Status}, MaxHits {MaxHits}, Hited {Hited} Color {Color}";
        }




    }
}
