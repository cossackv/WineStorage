using System;
using System.Collections;


namespace Wine_Storage
{
    public class WineStorage : Wine, IEnumerable
    {
        public Wine[] bottlesOfWine { get; set; }


        //public WineStorage()
        //{

        //}
        public WineStorage(Wine[] bottles) 
        {
             bottlesOfWine = new Wine[bottles.Length];
            for (int i = 0; i < bottles.Length; i++)
            {
                bottlesOfWine[i] = bottles[i];  
            }
        }

        public IEnumerator GetEnumerator()
        {
            return bottlesOfWine.GetEnumerator();
        }

        public Color GetColor() { return Color.White; }
    }
}
