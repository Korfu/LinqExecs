using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class Exec9_CountAfterGroupBy
    {
        public void GetCountAfterFrounBy(List<CarRow> oldlist)
        {
            Console.WriteLine("---------EXEC9: pogrupuj modele po producencie i wypisz ilu różnych producentów istnieje--------");
            var groupedBy = oldlist.GroupBy(x => x.Division);

            foreach (var group in groupedBy)
            {
                Console.WriteLine($"{group.Key} count is {group.Count()}");
            }
        }
    }
}
