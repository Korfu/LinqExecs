using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class Top10FuelConsumptionChevrolet
    {
        public void GetTop10FuelConsumptionChevrolet(List<CarRow> oldList)
        {
            Console.WriteLine("---------EXEC1: 10 modeli Chevroleta o najmniejszym spalaniu--------");
            var displayHelper = new DisplayHelper();

            var newList = oldList.Where(c => c.Division == "Chevrolet").OrderByDescending(x => x.CityFE).Take(10).ToList();

            foreach (var row in newList)
            {
                displayHelper.Display(row);
            }
        }
    }
}
