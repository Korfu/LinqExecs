using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class SortAlfabetically
    {
        public void GetSortAlfabetically(List<CarRow> oldList)
        {
            Console.WriteLine("---------EXEC3: powyżej posortowane alfabetycznie po Division--------");
            var displayHelper = new DisplayHelper();
            int multiplier = 282;

            var newList = oldList;
            foreach (var row in newList)
            {
                row.CityFE = multiplier / row.CityFE;
                row.HwyFE = multiplier / row.HwyFE;
                row.CombFe = multiplier / row.CombFe;

            }

            newList =oldList.OrderBy(x => x.CityFE).ThenBy(x => x.Division).Take(20).ToList();

            foreach (var row in newList)
            {
                displayHelper.Display(row);
            }
        }

    }
}
