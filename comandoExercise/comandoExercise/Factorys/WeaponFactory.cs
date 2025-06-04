using comandoExercise.Entitis.Weapons;
using comandoExercise.Entitis.Weapons.SootingWeapons;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace comandoExercise.Factorys
{
    internal class WeaponFactory
    {
        List<ShootingWeapon> hotWeapos = new List<ShootingWeapon>();
        List<Stone> stones = new List<Stone>();
        List<Knife> knives = new List<Knife>();






        public void FactoryShootingWeapon(string name, string manufacturer, int numberOfBalls)
        {
            switch (name.ToLower())
            {
                case "m16":
                    hotWeapos.Add(new M16(name, manufacturer, numberOfBalls));
                    break;
                case "ak47":
                    hotWeapos.Add(new AK47(name, manufacturer, numberOfBalls));
                    break;
                default:
                    break;
            }
        }
        public void FactoryStone(string name, int weghit, string color)
        {
            stones.Add(new Stone(name, weghit, color));
        }
        public void FactoryKnife(string name, int weghit, string color, string manufaturer, string metalType)
        {
            knives.Add(new Knife(name, weghit, color, manufaturer, metalType));
        }


        public void PrintHotWeapons()
        {
            foreach(ShootingWeapon hotWeapon in this.hotWeapos)
            {
                Console.WriteLine(hotWeapon);
            }
        }
        public void PrintStons()
        {
            foreach (Stone stone in this.stones)
            {
                Console.WriteLine(stone);
            }
        }
        public void PrintKnivis()
        {
            foreach (Knife knife in this.knives)
            {
                Console.WriteLine(knife);
            }
        }

        public List<ShootingWeapon> GetAllHotWeapos()
        {
            return this.hotWeapos;
        }
        public List<Stone> GetAllStons()
        {
            return this.stones;
        }
        public List<Knife> GetAllKnives()
        {
            return this.knives;
        }

































        //public void FactoryWeapon(string name, string manufacturer, int numberOfBalls)
        //{
        //    weapons.Add(new ShootingWeapon(name, manufacturer, numberOfBalls));
        //}


        //Random rnd = new Random();

        //public void AddNewWeapons(int howMuch)
        //{
        //    for (int i = 0; i < howMuch; i++)
        //    {
        //        hotWeapos.Add(CreateWeapon());
        //    }
        //}
        //public ShootingWeapon CreateWeapon()
        //{
        //    string[] names = {"gun", "riful", "cannon" };
        //    string[] manufacturers = {"refael", "albit", "idf" };

        //    string name = names[rnd.Next(names.Length)];
        //    string manufacturer = manufacturers[rnd.Next(manufacturers.Length)];
        //    int bulits = rnd.Next(12, 25);

        //    ShootingWeapon weapon = new ShootingWeapon(name, manufacturer,bulits);

        //    return weapon;
        //}
    }
}
