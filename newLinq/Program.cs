using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using newLinq.Excercises;

namespace newLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
            var top10BestFe = new Exec1_Top10BestFe();
            top10BestFe.GetTop10BestFe(carList);

            //exec2
            var fuelConsumptionInLPer100Km = new Exec2_FuelConsumptionInLPer100Km();
            fuelConsumptionInLPer100Km.GetFuelConsumptionInLPer100Km(carList);

            //exec3
            var sortAlfabetically = new Exec3_SortAlfabetically();
            sortAlfabetically.GetSortAlfabetically(carList);

            //exec4
            var top10FuelConsumptionChevrolet = new Exec4_Top10FuelConsumptionChevrolet();
            top10FuelConsumptionChevrolet.GetTop10FuelConsumptionChevrolet(carList);

            //exec5
            var bMWFuelEfficencyUnder20 = new Exec5_BMWFuelEfficencyUnder20();
            bMWFuelEfficencyUnder20.GetBMWFuelEfficencyUnder20(carList);

            //exec6
            var areAllPorshe = new Exec6_AreAllPorshe();
            areAllPorshe.CheckIfAreAllPorshe(carList);

            //exec7 prawdzy czy istnieje jaki kolwiek model wyprodukowany przez "Fiat", to samo dla "Olds Mobile"
            var anyFiatOrOldsMobile = new Exec7_AnyFiatOrOldsMobile();
            anyFiatOrOldsMobile.CheckIfAnyFiatOrOldsMobile(carList);

            //exec8 pogrupuj modele po producencie i wypisz ilu różnych producentów istnieje
            var groupByModelAndHowManyProducents = new Exec8_GroupByModelAndHowManyProducents();
            groupByModelAndHowManyProducents.GetGroupByModelAndHowManyProducents(carList);


            //exec9 używając grup z poprzedniego punktu wypisz liczebność każdej grupy
            var countAfterGroupBy = new Exec9_CountAfterGroupBy();
            countAfterGroupBy.GetCountAfterFrounBy(carList);


            //exec10 wypisz producentów dla których istnieje conajmniej 50 modeli/ 20 modeli
            var allProdcuentsWith20to50Cars = new Exec10_AllProdcuentsWith20to50Cars();
            allProdcuentsWith20to50Cars.GetAllProdcuentsWith20to50Cars(carList);

            //exec11 dla producentów dla których istnieje conajmniej 20 modeli wypisz wszystkie modele
            var displayAllModlesForTheOnesBetween20and50 = new Exec11_DisplayAllModlesForTheOnesBetween20and50();
            displayAllModlesForTheOnesBetween20and50.GetDisplayAllModlesForTheOnesBetween20and50(carList);

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
