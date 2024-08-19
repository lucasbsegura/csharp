namespace WhatsNewCSharp8
{
    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public static class SwitchExpressions
    {
        public static string CheckMonth(Months month) => month switch
        {
            Months.December or Months.January or Months.February or Months.March => "Winter",
            Months.April or Months.May or Months.June => "Spring",
            Months.July or Months.August or Months.September => "Summer",
            Months.October or Months.November => "Autumn",
            _ => "Invalid",
        };

    }
}
