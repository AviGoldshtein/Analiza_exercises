using comandoExercise.Entitis.Weapons;
using comandoExercise.Factorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace comandoExercise
{
    internal class GAME
    {
        private WeaponFactory weaponFactory = new WeaponFactory();
        private EnemyFactory enemyFactory = new EnemyFactory();
        private CommandoFactory commandoFactory = new CommandoFactory();

        public void run()
        {
            List<ShootingWeapon> shootingWeapons = weaponFactory.GetAllHotWeapos();
            weaponFactory.FactoryShootingWeapon("ak47", "ZIK", 27);
            weaponFactory.FactoryShootingWeapon("m16", "COLD", 19);
            //weaponFactory.FactoryShootingWeapon("ak47", "ZIK", 27);

            for (int i = 0; i < 30; i++)
            {
                foreach (ShootingWeapon weapon in shootingWeapons)
                {
                    weapon.Shoot();
                }
            }

            
            //weaponFactory.FactoryShootingWeapon("m16", "COLD", 25);

            //enemyFactory.FactoyEnemy("muchamad");

            //commandoFactory.FactoyCommando("commando", "avi", "kodkod");
            //commandoFactory.FactoyCommando("air commando", "moshe", "nimridy");
            //commandoFactory.FactoyCommando("sea commando", "yakov", "danger");

            //Console.WriteLine("hot wepons:\n");
            //weaponFactory.PrintHotWeapons();
            //weaponFactory.FactoryStone("even echad", 50, "black");
            //weaponFactory.FactoryStone("even echad", 50, "black");
            //weaponFactory.FactoryStone("even echad", 50, "black");
            //weaponFactory.FactoryStone("even echad", 50, "black");
            //weaponFactory.FactoryStone("even echad", 50, "black");
            //weaponFactory.FactoryStone("even echad", 50, "black");

            //weaponFactory.FactoryKnife("sakin echad", 5, "yellow", "china", "kuper");
            //weaponFactory.FactoryKnife("sakin echad", 5, "yellow", "china", "kuper");
            //weaponFactory.FactoryKnife("sakin echad", 5, "yellow", "china", "kuper");
            //weaponFactory.FactoryKnife("sakin echad", 5, "yellow", "china", "kuper");
            //weaponFactory.FactoryKnife("sakin echad", 5, "yellow", "china", "kuper");
            //weaponFactory.FactoryKnife("sakin echad", 5, "yellow", "china", "kuper");
            //weaponFactory.PrintKnivis();



            //weaponFactory.PrintStons();


        }
    }
}
