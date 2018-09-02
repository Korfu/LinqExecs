using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    class Exec10_AllProdcuentsWith20to50Cars
    {
        public void GetAllProdcuentsWith20to50Cars(List<CarRow> oldlist)
        {
            Console.WriteLine("---------EXEC10: wypisz producentów dla których istnieje conajmniej 50 modeli/ 20 modeli--------");
            var between20and50 = oldlist.GroupBy(x => x.Division).Where(x => x.Count() > 20 && x.Count() < 50);
            foreach (var group in between20and50)
            {
                Console.WriteLine($"{group.Key}");
            }
        }
    }
}
