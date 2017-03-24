using System;

namespace Objects
{
    public static class Constants
    {
        public static Nullable<DateTime> NULL_DATE = null;
        //public static DateTime hhh = DateTime.MaxValue.AddYears(-1);
        public static DateTime DTP_MAX_DATE = new DateTime(DateTime.MaxValue.Year - 1, DateTime.MaxValue.Month, DateTime.MaxValue.Day, 0, 0, 0);

        public const char NULL_CHAR = '\0';
    }
}