using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class Director
    {
        public Character ConstructHero(ICharacterBuilder builder)
        {
            return builder.SetHeight(180)
                          .SetBuild("Athletic")
                          .SetHairColor("Blonde")
                          .SetEyeColor("Blue")
                          .SetClothing("Armor")
                          .AddInventoryItem("Sword")
                          .AddInventoryItem("Shield")
                          .AddSpecialAction("Save the World")
                          .Build();
        }

        public Character ConstructEnemy(ICharacterBuilder builder)
        {
            return builder.SetHeight(200)
                          .SetBuild("Muscular")
                          .SetHairColor("Black")
                          .SetEyeColor("Red")
                          .SetClothing("Dark Robe")
                          .AddInventoryItem("Staff")
                          .AddInventoryItem("Potion")
                          .AddSpecialAction("Destroy the World")
                          .Build();
        }
    }

}
