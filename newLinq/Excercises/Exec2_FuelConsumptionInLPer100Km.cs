using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class Exec2_FuelConsumptionInLPer100Km
    {
        public void GetFuelConsumptionInLPer100Km(List<CarRow> oldList)
        {
            Console.WriteLine("---------EXEC2: spalanie w KM/H--------");
            var displayHelper = new DisplayHelper();

            var newList = oldList.OrderByDescending(x => x.CityFE).Take(20).ToList();
            int multiplier = 282;
            foreach (var row in newList)
            {
                row.CityFE = multiplier /row.CityFE;
                row.HwyFE = multiplier / row.HwyFE;
                row.CombFe = multiplier / row.CombFe;
                displayHelper.Display(row);
            }
        }
    }
}
