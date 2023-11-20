using CoreCourse.DIBasics.Core.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Cream : ICreamer
    {
        public Cream()
        {
            Name = "Cream";
            LactosePercent = 0;
            AlcoholPercent = 0;
        }

        public string Name { get; protected set; }
        public double LactosePercent { get; protected set; }
        public double AlcoholPercent { get; protected set; }

    }
}
