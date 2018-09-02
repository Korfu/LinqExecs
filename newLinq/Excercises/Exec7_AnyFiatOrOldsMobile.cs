using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class Exec7_AnyFiatOrOldsMobile
    {
        public void CheckIfAnyFiatOrOldsMobile (List<CarRow> oldlist)
        {
            Console.WriteLine("---------EXEC7: czy jakiś to Fiat albo Olds Mobile--------");
            var anyFiat = oldlist.Any(c => c.Division == "Fiat");
            if (anyFiat)
            {
                Console.WriteLine("There are some Fiats");
            }
            else Console.WriteLine("There are no Fiats");

            var anyOlds = oldlist.Any(c => c.Division == "Olds Mobile");
            if (anyOlds)
            {
                Console.WriteLine("There are some Olds Mobiles");
            }
            else Console.WriteLine("There are no Olds Mobiles");
        }
    }
}
