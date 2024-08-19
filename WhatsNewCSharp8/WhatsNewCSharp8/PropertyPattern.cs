namespace WhatsNewCSharp8
{
    public enum Cities
    {
        Vienna,
        Berlin,
        Amsterdam,
        Madrid,
        Budapest,
        Paris,
        London,
        Warsaw,
        Prague,
        Melbourne,
        Bauru
    }

    public class City
    {
        public Cities CityName { get; set; }
        public string CountryName { get; set; }
        public City(Cities city, string country) 
        {
            CityName = city;
            CountryName = country;
        }
    }
}
