using CoreCourse.DIBasics.Core.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.ViewModels
{
    public class CoffeeViewModel
    {
        public ICoffeeCup CoffeeCup { get; set; }
    }
}
