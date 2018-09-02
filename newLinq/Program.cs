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


            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        


    }
}
