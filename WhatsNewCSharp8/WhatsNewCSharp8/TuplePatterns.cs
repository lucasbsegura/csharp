namespace WhatsNewCSharp8
{
    public class TuplePatterns
    {
        public static string CheckPrices(string city, string country, string language) =>
            (city, country, language) switch
            {
                ("Vienna", "Austria", "German") => "Above Average",
                ("Paris", "France", "Feench") => "Pretty High",
                ("Paris",_,_) => "Average",
                (_,_,_) => "Invalid"
            };
        public static string CheckPrices(string city, string country) =>
            (city, country) switch
            {
                ("Vienna", "Austria") => "Above Average",
                ("Paris", "France") => "Pretty High",
                ("Paris", "USA") => "Average",
                (_,_) => "Invalid"
            };
    }
}
