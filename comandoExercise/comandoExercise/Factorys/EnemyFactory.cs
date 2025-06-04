using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Factorys
{
    internal class EnemyFactory
    {
        List<Enemy> enemies = new List<Enemy>();

        public void FactoyEnemy(string name)
        {
            enemies.Add(new Enemy(name));
        }






















        //public void AddNewEnemys(int howMuch)
        //{
        //    for (int i = 0; i < howMuch; i++)
        //    {
        //        enemies.Add(CreateEnemy());
        //    }  
        //}
        //public Enemy CreateEnemy()
        //{
        //    Enemy enemy = new Enemy();
        //    return enemy;
        //}
    }
}
