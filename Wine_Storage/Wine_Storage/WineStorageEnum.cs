using System;
using System.Collections;


namespace Wine_Storage
{
    public class WineStorageEnum : IEnumerator
    {
        public WineStorage[] listOfBottles;

        int position = -1;

        public WineStorageEnum(WineStorage[] list)
        {
            listOfBottles = list;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }


        public WineStorage Current
        {
            get
            {
                try
                {
                    return listOfBottles[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < listOfBottles.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
