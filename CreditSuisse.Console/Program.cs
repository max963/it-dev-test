namespace CreditSuisse.Console
{
    using System;
    using System.Collections.Generic;
    using CreditSuisse.Application.Services;
    using CreditSuisse.Domain.Entities;
    using CreditSuisse.Helpers.Utils;

    public class Program
    {
        public static void Main()
        {
            var dateReference = InteractionUtils.ReadDateValue("Choose the Reference Date: ");
            var numberTrades = InteractionUtils.ReadInValue("Choose the number of trades: ");

            var tradeService = new TradeService();
            var tradeList = new List<Trade>();

            for (var i = 0; i < numberTrades; i++)
            {
                var tradeString = InteractionUtils.ReadStringValue($"Entry {i + 1}: ");
                var trade = tradeService.ReadRawTrade(tradeString);
                tradeService.DefineCategory(dateReference, trade);
                tradeList.Add(trade);
            }

            Console.WriteLine("Categories: ");

            foreach (var trade in tradeList)
            {
                Console.WriteLine($"{trade.Category.CategoryName}");
            }

        }
    }
}
