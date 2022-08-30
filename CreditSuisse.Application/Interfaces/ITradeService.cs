namespace CreditSuisse.Application.Interfaces
{
    using System;
    using CreditSuisse.Domain.Entities;

    public interface ITradeService
    {
        Trade ReadRawTrade(string tradeString);
        void DefineCategory(DateTime refDate, Trade trade);
    }
}
