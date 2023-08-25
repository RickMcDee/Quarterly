namespace Quarterly
{
    public static class Quarterly
    {
        public static int GetQuarter(this DateTime dateTime)
        {
            return (dateTime.Month + 2) / 3;
        }

        public static int GetQuarterFromDateTime(DateTime dateTime)
        {
            return dateTime.GetQuarter();
        }

        public static DateTime GetQuarterStart(this DateTime dateTime)
        {
            var quarter = dateTime.GetQuarter();
            return new(dateTime.Year, (quarter - 1) * 3 + 1, 1);
        }

        public static DateTime GetQuarterStartFromDateTime(DateTime dateTime)
        {
            return dateTime.GetQuarterStart();
        }

        public static DateTime GetQuarterEnd(this DateTime dateTime)
        {
            var quarterStart = dateTime.GetQuarterStart();
            return quarterStart.AddMonths(3).AddDays(-1);
        }

        public static DateTime GetQuarterEndFromDateTime(DateTime dateTime)
        {
            return dateTime.GetQuarterEnd();
        }

        public static int GetDayInQuarter(this DateTime dateTime)
        {
            var quarterStart = dateTime.GetQuarterStart();
            return (dateTime.DayOfYear - quarterStart.DayOfYear) + 1;
        }

        public static int GetDayInQuarterFromDateTime(DateTime dateTime)
        {
            return dateTime.GetDayInQuarter();
        }
    }
}