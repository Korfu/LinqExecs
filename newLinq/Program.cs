using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newLinq.Excercises;

namespace newLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var top10BestFe = new Top10BestFe();
            var fuelConsumptionInLPer100Km= new FuelConsumptionInLPer100Km();
            var sortAlfabetically = new SortAlfabetically();
            var top10FuelConsumptionChevrolet = new Top10FuelConsumptionChevrolet();
            var bMWFuelEfficencyUnder20 = new BMWFuelEfficencyUnder20();
            var areAllPorshe = new AreAllPorshe();

            string[] rows = File.ReadAllLines("Excel Files/fuel.csv");

            var headers = rows.First().Split(',');
            foreach (var header in headers)
            {
                Console.Write($"{header.ToString(),-26}|");
            }
            Console.WriteLine();

            var carList = new List<CarRow>();
            carList = rows.Skip(1).Select(r=> 
            {
                string[] splitted = r.Split(',');
                return new CarRow()
                {
                    ModelYear = int.Parse(splitted[0]),
                    Division = splitted[1],
                    Carline = splitted[2],
                    EngDispl = decimal.Parse(splitted[3]),
                    Cylinders = int.Parse(splitted[4]),
                    CityFE = int.Parse(splitted[5]),
                    HwyFE = int.Parse(splitted[6]),
                    CombFe = int.Parse(splitted[7]),
                };
            }).ToList();

            //exec1
            top10BestFe.GetTop10BestFe(carList);

            //exec2
            fuelConsumptionInLPer100Km.GetFuelConsumptionInLPer100Km(carList);

            //exec3
            sortAlfabetically.GetSortAlfabetically(carList);

            //exec4
            top10FuelConsumptionChevrolet.GetTop10FuelConsumptionChevrolet(carList);

            //exec5
            bMWFuelEfficencyUnder20.GetBMWFuelEfficencyUnder20(carList);

            //exec6
            areAllPorshe.CheckIfAreAllPorshe(carList);

            //exec7 prawdzy czy istnieje jaki kolwiek model wyprodukowany przez "Fiat", to samo dla "Olds Mobile"
            Console.WriteLine("---------EXEC7: czy jakiś to Fiat albo Olds Mobile--------");
            var anyFiat = carList.Any(c => c.Division == "Fiat");
            if (anyFiat)
            {
                Console.WriteLine("There are some Fiats");
            }
            else Console.WriteLine("There are no Fiats");

            var anyOlds = carList.Any(c => c.Division == "Olds Mobile");
            if (anyOlds)
            {
                Console.WriteLine("There are some Olds Mobiles");
            }
            else Console.WriteLine("There are no Olds Mobiles");

            //exec8 pogrupuj modele po producencie i wypisz ilu różnych producentów istnieje
            Console.WriteLine("---------EXEC8: pogrupuj modele po producencie i wypisz ilu różnych producentów istnieje--------");
            var groupedBy = carList.GroupBy(x => x.Division);
            Console.WriteLine($"There are {groupedBy.Count()} Producents");


            //exec9 używając grup z poprzedniego punktu wypisz liczebność każdej grupy
            Console.WriteLine("---------EXEC9: pogrupuj modele po producencie i wypisz ilu różnych producentów istnieje--------");
            foreach (var group in groupedBy)
            {
                Console.WriteLine($"{group.Key} count is {group.Count()}");
            }

            //exec10 wypisz producentów dla których istnieje conajmniej 50 modeli/ 20 modeli
            Console.WriteLine("---------EXEC10: wypisz producentów dla których istnieje conajmniej 50 modeli/ 20 modeli--------");

            var between20and50 = groupedBy.Where(x => x.Count() > 20 && x.Count() < 50);
            foreach (var group in between20and50)
            {
                Console.WriteLine($"{group.Key}");
            }

            //exec11 dla producentów dla których istnieje conajmniej 20 modeli wypisz wszystkie modele
            Console.WriteLine("---------EXEC11:producentów dla których istnieje conajmniej 20 modeli wypisz wszystkie modele");

            var selectmany = between20and50.SelectMany(x => x).Select(x => x.Carline).Distinct();
            foreach (var item in selectmany)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        


    }
}
