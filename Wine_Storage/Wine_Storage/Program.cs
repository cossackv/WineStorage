using System;

namespace Wine_Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           WineStorage store = new WineStorage(new Wine[]
           {
               new Wine(ABV.LowABV, CropYear.Nineteen_Ninety_Seven, Color.Pink),
               new Wine(ABV.HighABV, CropYear.Two_Thousand, Color.Red)
           });

            foreach (var wine in store)
            {
                Console.WriteLine(wine);
            }
        }
    }
}
