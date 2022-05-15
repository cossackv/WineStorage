using System;
using System.Collections.Generic;


namespace Wine_Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WineStorage bottleOfWine1 = new WineStorage();


            List<Wine> list = new List<Wine>()
            {
               new Wine(ABV.Medium_HighABV, CropYear.Two_Thousand, Color.White),
               new Wine(ABV.Medium_LowABV, CropYear.Nineteen_Eighty_Six, Color.Red),
               new Wine(ABV.LowABV, CropYear.Nineteen_Ninety_Seven, Color.Red)
               
            };



            //var result = bottleOfWine1.GetColor(list, Color.Red);
            //PrintToTerminal(result);

            //var sort = bottleOfWine1.SortData(list);
            //PrintToTerminal(sort);

            var sortABV = bottleOfWine1.SortABV(list);
            PrintToTerminal(sortABV);

            //foreach (var wine in list)
            //{
            //    Console.WriteLine(wine);
            //}
        }

        public static void PrintToTerminal(List<Wine> list)
        {
            Console.WriteLine(String.Join("\n", list));
        }
    }
}
