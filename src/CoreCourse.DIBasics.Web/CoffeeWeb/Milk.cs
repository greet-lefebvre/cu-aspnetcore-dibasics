using CoreCourse.DIBasics.Core.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Milk : ICreamer
    {
        public Milk()
        {
            Name = "Milk";
            LactosePercent = 0.048;
            AlcoholPercent = 0;
        }

        public string Name { get; protected set; }
        public double LactosePercent { get; protected set; }
        public double AlcoholPercent { get; protected set; }
    }
}
