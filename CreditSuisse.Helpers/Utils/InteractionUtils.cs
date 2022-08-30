namespace CreditSuisse.Helpers.Utils
{
    using System;

    public static class InteractionUtils
    {
        public static string ReadStringValue(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static DateTime ReadDateValue(string message)
        {
            Console.Write(message);
            var entry = Console.ReadLine();
            return ParseUtils.ParseDateTime(entry);
        }

        public static int ReadInValue(string message)
        {
            Console.Write(message);
            var entry = Console.ReadLine();
            return ParseUtils.ParseInt(entry);
        }
    }
}
