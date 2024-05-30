using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public interface IHero
    {
        string Name { get; }
        int GetPower();
        string GetDescription();
    }

}
