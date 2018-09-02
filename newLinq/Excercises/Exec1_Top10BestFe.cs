using System;
using System.Collections.Generic;
using System.Linq;

namespace newLinq.Excercises
{
    public class Exec1_Top10BestFe
    {
        public void GetTop10BestFe(List<CarRow> oldList)
        {
            Console.WriteLine("---------EXEC1: 10 modeli o najmniejszym spalaniu--------");
            var displayHelper = new DisplayHelper();

            var newList = oldList.OrderByDescending(x => x.CityFE).Take(10).ToList();

            foreach (var row in newList)
            {
                displayHelper.Display(row);
            }
        }
    }
}
