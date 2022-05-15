using System;


namespace Wine_Storage
{
    #region EnumsCollection
    public enum Color
    {
        Red, 
        White, 
        Pink, 
        Orange, 
        Yellow
    }

    public enum ABV
    {
        LowABV = 5,
        Medium_LowABV = 10,
        MediumABV = 11,
        Medium_HighABV = 14,
        HighABV = 15
    }
    public enum CropYear
    {
        Nineteen_Seventy_Six = 1976,
        Nineteen_Eighty_Six = 1986,
        Nineteen_Ninety_Seven = 1997,
        Two_Thousand = 2000,
        Two_Thousand_AND_Tenth = 2010,

    }

    #endregion

    public class Wine
    {
        public ABV alcoholByVolume { get; set; }
        public CropYear cropYear { get; set; }
        public Color color { get; set; }

        public Wine()
        {

        }
        public Wine(ABV abv, CropYear crop, Color color)
        {
            alcoholByVolume = abv;
            cropYear = crop;
            this.color = color;
        }

        public override string ToString()
        {
            return $"ABV of Wine is {alcoholByVolume}. Year of crop {cropYear}. Color is {color}";
        }
    }
}
