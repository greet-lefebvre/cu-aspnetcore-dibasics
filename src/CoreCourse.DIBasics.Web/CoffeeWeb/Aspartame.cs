using CoreCourse.DIBasics.Core.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class Aspartame : ISweetener
    {
        public Aspartame()
        {
            Name = "Aspartame";
        }
        public string Name { get; protected set; }
    }
}
