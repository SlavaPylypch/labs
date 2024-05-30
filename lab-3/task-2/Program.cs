using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHero warrior = new Warrior("Conan");
            IHero mage = new Mage("Gandalf");
            IHero paladin = new Paladin("Arthur");

            warrior = new Armor(warrior);
            warrior = new Weapon(warrior);
            warrior = new Artifact(warrior);

            mage = new Weapon(mage);
            mage = new Artifact(mage);

            paladin = new Armor(paladin);
            paladin = new Artifact(paladin);
            paladin = new Weapon(paladin);

            Console.WriteLine($"{warrior.Name} is a {warrior.GetDescription()} with power {warrior.GetPower()}.");
            Console.WriteLine($"{mage.Name} is a {mage.GetDescription()} with power {mage.GetPower()}.");
            Console.WriteLine($"{paladin.Name} is a {paladin.GetDescription()} with power {paladin.GetPower()}.");
            Console.ReadKey();
        }
    }
}
