using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero _hero;

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string Name => _hero.Name;

        public virtual int GetPower()
        {
            return _hero.GetPower();
        }

        public virtual string GetDescription()
        {
            return _hero.GetDescription();
        }
    }

}
