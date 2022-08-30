namespace CreditSuisse.Application.Services
{
    using System;
    using CreditSuisse.Application.Interfaces;
    using CreditSuisse.Domain.Entities;
    using CreditSuisse.Helpers.Utils;

    public sealed class TradeService : ITradeService, IBaseService<Trade>
    {
        public Trade Add(Trade entity) => throw new NotImplementedException();

        public void DefineCategory(DateTime refDate, Trade trade)
        {
            var datedif = (trade.NextPaymentDate - refDate).TotalDays;
            if (datedif < -30)
            {
                trade.DefineCategory(new TradeCategory { CategoryName = "EXPIRED" });
            }
            else if (trade.Value > 1000000 && trade.ClientSector.Equals(EnumClientSector.Private))
            {
                trade.DefineCategory(new TradeCategory { CategoryName = "HIGHRISK" });
            }
            else if (trade.Value > 1000000 && trade.ClientSector.Equals(EnumClientSector.Public))
            {
                trade.DefineCategory(new TradeCategory { CategoryName = "MEDIUMRISK" });
            }

        }

        public void Delete(Trade entity) => throw new NotImplementedException();

        public Trade ReadRawTrade(string tradeString)
        {
            var amount = tradeString.Split(" ")[0];
            var cSector = tradeString.Split(" ")[1];
            var nxtPayment = tradeString.Split(" ")[2];

            var tradeAmount = ParseUtils.ParseDouble(amount);
            Enum.TryParse(typeof(EnumClientSector), cSector, out var outClientSector);

            var nextPayment = ParseUtils.ParseDateTime(nxtPayment);

            var trade = new Trade(tradeAmount, (EnumClientSector)outClientSector, nextPayment);

            return trade;
        }

        public Trade Update(Trade entity) => throw new NotImplementedException();
    }
}
