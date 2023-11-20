using CoreCourse.DIBasics.Core.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Honey : ISweetener
    {
        public Honey()
        {
            Name = "Honey";
        }

        public string Name { get; protected set; }

    }
}
