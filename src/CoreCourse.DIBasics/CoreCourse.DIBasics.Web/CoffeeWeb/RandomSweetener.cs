using CoreCourse.DIBasics.Core.CoffeeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.DIBasics.Web.CoffeeWeb
{
    public class RandomSweetener : ISweetener
    {
        private ISweetener _chosenSweetener;
        private static Random _random;

        public RandomSweetener(Random random)
        {
            _random = random;
            _chosenSweetener = PickRandomSweetener();
        }

        public string Name => _chosenSweetener.Name;

        private ISweetener PickRandomSweetener()
        {
            //pick random sweetener
            switch (_random.Next(0, 3))
            {
                case 1:
                    return new Honey();
                case 2:
                    return new Aspartame();
                default:
                    return new Sugar();
            }
        }
    }
}
