using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class Exec5_BMWFuelEfficencyUnder20
    {
        public void GetBMWFuelEfficencyUnder20(List<CarRow> oldList)
        {
            Console.WriteLine("---------EXEC5: model BMW który ma spalanie mniejsze niż 20--------");
            var displayHelper = new DisplayHelper();

            var thisBMW = oldList.Where(c => c.Division == "BMW").Where(f => f.CityFE <20).FirstOrDefault();
            if (thisBMW != null)
            {
                displayHelper.Display(thisBMW);
            }
            else Console.WriteLine("No such BMW with Fuel efficiency under 20!");

        }

    }
}
