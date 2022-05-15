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
        LowABV,
        Medium_LowABV,
        MediumABV,
        Medium_HighABV,
        HighABV
    }
    public enum CropYear
    {
        Nineteen_Seventy_Six,
        Nineteen_Eighty_Six,
        Nineteen_Ninety_Seven,
        Two_Thousand,
        Two_Thousand_AND_Tenth,

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
