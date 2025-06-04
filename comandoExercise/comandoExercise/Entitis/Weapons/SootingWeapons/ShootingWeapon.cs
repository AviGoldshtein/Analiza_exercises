using comandoExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise
{
    internal class ShootingWeapon : IShootable
    {
        private string Name;
        private string Manufacturer;
        private int NumberOfBulits;

        public ShootingWeapon(string name, string manufacturer, int numberOfBalls)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.NumberOfBulits = numberOfBalls;
        }

        public void Shoot()
        {
            if (CanShoot())
            {
                Console.WriteLine($"{this.Name} is Shooting !!!!");
                this.NumberOfBulits--;
                Console.WriteLine($"{this.NumberOfBulits} bullits remained");
            }
            else
            {
                Console.WriteLine("the stuck is empty");
            }
        }

        public int CheckBullits()
        {
            return this.NumberOfBulits;
        }

        public bool CanShoot()
        {
            return CheckBullits() > 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Manufacturer {Manufacturer}, NumberOfBulits {NumberOfBulits}";
        }
    }
}
