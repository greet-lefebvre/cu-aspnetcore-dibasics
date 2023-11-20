using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Core.CoffeeSystem
{
    public class CoffeeCup : ICoffeeCup
    {
        public CoffeeCup(ICreamer creamer, ISweetener sweetener)
        {
            Creamer = creamer;
            Sweetener = sweetener;
        }

        public ICreamer Creamer { get; set; }

        public ISweetener Sweetener { get; set; }
    }
}
