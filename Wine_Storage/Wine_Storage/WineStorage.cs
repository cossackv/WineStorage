using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Wine_Storage
{
    public class WineStorage : Wine, IEnumerable
    {
        public Wine wine;

        public Wine[] bottlesOfWine { get; set; }


        public WineStorage()
        {

        }
        public WineStorage(Wine[] bottles) 
        {
             bottlesOfWine = new Wine[bottles.Length];
            for (int i = 0; i < bottles.Length; i++)
            {
                bottlesOfWine[i] = bottles[i];  
            }
        }

        public WineStorage(Wine wine)
        {
            this.wine = wine;
        }

        public IEnumerator GetEnumerator()
        {
            return bottlesOfWine.GetEnumerator();
        }

        #region GetColor
        /// <summary>
        /// Method to find a specific color of Wine in collection
        /// </summary>
        public List<Wine> GetColor(List<Wine> list, Color cl)
        {
            var query = list.FindAll(x => x.color == cl);

            return query;
        }
        #endregion

        #region Sorting
        /// <summary>
        /// Method to sort a collection by Date
        /// </summary>
        public List<Wine> SortData(List<Wine> list)
        {
            var query = list.OrderBy(x => x.cropYear).ToList();

            return query;
        }

        /// <summary>
        /// Method to sort a collection by global standard of measurement for alcohol content
        /// </summary>
        public List<Wine> SortABV(List<Wine> list)
        {
            var query = list.OrderBy(x => x.alcoholByVolume).ToList();

            return query;
        }
        #endregion
    }


}
