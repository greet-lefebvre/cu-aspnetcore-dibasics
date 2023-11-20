using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Core.CoffeeSystem
{
    public interface ICreamer
    {
        string Name { get; }
        double LactosePercent { get; }
        double AlcoholPercent { get; }
    }
}
