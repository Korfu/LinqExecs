using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    class Exec11_DisplayAllModlesForTheOnesBetween20and50
    {
        public void GetDisplayAllModlesForTheOnesBetween20and50(List<CarRow> oldlist)
        {
            Console.WriteLine("---------EXEC11:producentów dla których istnieje conajmniej 20 modeli wypisz wszystkie modele");

            var selectmany = oldlist.GroupBy(x => x.Division).Where(x => x.Count() > 20 && x.Count() < 50).SelectMany(x => x).Select(x => x.Carline).Distinct();
            foreach (var item in selectmany)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
