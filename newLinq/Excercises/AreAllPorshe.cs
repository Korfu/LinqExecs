using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLinq.Excercises
{
    public class AreAllPorshe
    {
        public void CheckIfAreAllPorshe(List<CarRow> oldList)
        {
            Console.WriteLine("---------EXEC6: czy wszystkie to Porsche--------");
            var displayHelper = new DisplayHelper();

            var hasAtLeastOne = oldList.All(c => c.Division == "Porshe");
            if (hasAtLeastOne)
            {
                Console.WriteLine("ALL are Porsches");
            }
            else Console.WriteLine("NOT all are Porsches");
        }
    }
}
