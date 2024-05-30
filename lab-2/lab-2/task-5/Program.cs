using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            ICharacterBuilder heroBuilder = new HeroBuilder();
            Character hero = director.ConstructHero(heroBuilder);
            Console.WriteLine("Hero:");
            hero.DisplayInfo();

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            Character enemy = director.ConstructEnemy(enemyBuilder);
            Console.WriteLine("\nEnemy:");
            enemy.DisplayInfo();
            Console.ReadKey();
        }
    }
}
