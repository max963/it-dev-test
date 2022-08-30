namespace CreditSuisse.Helpers.Utils
{
    using System;
    using System.Globalization;

    public static class ParseUtils
    {
        public static DateTime ParseDateTime(string entry)
        {
            try
            {
                string[] formats = { "MM/dd/yyyy" };
                var date = DateTime.ParseExact(entry, formats, new CultureInfo("en-US"));
                return date;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ParseInt(string entry)
        {
            int.TryParse(entry, out var outValue);
            return outValue;
        }

        public static double ParseDouble(string entry)
        {
            double.TryParse(entry, out var outValue);
            return outValue;
        }
    }
}
