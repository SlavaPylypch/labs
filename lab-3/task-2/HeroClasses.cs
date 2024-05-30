using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Warrior : IHero
    {
        public string Name { get; private set; }

        public Warrior(string name)
        {
            Name = name;
        }

        public int GetPower()
        {
            return 10; // Базова сила воїна
        }

        public string GetDescription()
        {
            return "Warrior";
        }
    }

    public class Mage : IHero
    {
        public string Name { get; private set; }

        public Mage(string name)
        {
            Name = name;
        }

        public int GetPower()
        {
            return 8; // Базова сила мага
        }

        public string GetDescription()
        {
            return "Mage";
        }
    }

    public class Paladin : IHero
    {
        public string Name { get; private set; }

        public Paladin(string name)
        {
            Name = name;
        }

        public int GetPower()
        {
            return 12; // Базова сила паладина
        }

        public string GetDescription()
        {
            return "Paladin";
        }
    }

}
