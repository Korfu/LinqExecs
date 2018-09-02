using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    class Exec8_GroupByModelAndHowManyProducents
    {
        public void GetGroupByModelAndHowManyProducents(List<CarRow> oldlist)
        {
            Console.WriteLine("---------EXEC8: pogrupuj modele po producencie i wypisz ilu różnych producentów istnieje--------");
            var groupedBy = oldlist.GroupBy(x => x.Division);
            Console.WriteLine($"There are {groupedBy.Count()} Producents");
        }
    }
}
