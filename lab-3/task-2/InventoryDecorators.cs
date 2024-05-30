using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override int GetPower()
        {
            return _hero.GetPower() + 5; // Додає силу за броню
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Armor";
        }
    }

    public class Weapon : HeroDecorator
    {
        public Weapon(IHero hero) : base(hero) { }

        public override int GetPower()
        {
            return _hero.GetPower() + 7; // Додає силу за зброю
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Weapon";
        }
    }

    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override int GetPower()
        {
            return _hero.GetPower() + 3; // Додає силу за артефакт
        }

        public override string GetDescription()
        {
            return _hero.GetDescription() + " with Artifact";
        }
    }

}
