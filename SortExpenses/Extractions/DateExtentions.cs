using System;
using System.Globalization;

namespace SortExpenses.Extractions
{
    public static class DateExtentions
    {
        public const string ddMMyyyySlashes = "dd/MM/yyyy";
        public const string ddMMyySlashes = "dd/MM/yy";
        public const string ddMMyyyyDashes = "dd-MM-yyyy";
        public const string ddMMyyDashes = "dd-MM-yy";
        public const string ddMMMyyyyDashes = "dd-MMM-yyyy";
        public const string ddMMMyyDashes = "dd-MMM-yy";
        public const string ddMMMyyyySlashes = "dd/MMM/yyyy";
        public const string ddMMMyySlashes = "dd/MMM/yy";
        public const string ddMMMMyyyyWhitespace = "dd MMMM yyyy";
        public const string dMMMMyyyyWhitespace = "d MMMM yyyy";

        public static DateTime ToDate(this string source, string format)
        {
            return DateTime.ParseExact(source, format, new CultureInfo("en"));
        }
    }
}