using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Core.CoffeeSystem
{
    public interface ICoffeeCup
    {
        ICreamer Creamer { get; }
        ISweetener Sweetener { get; }
    }
}
