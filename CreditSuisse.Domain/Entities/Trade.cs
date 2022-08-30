namespace CreditSuisse.Domain.Entities
{
    using System;
    using CreditSuisse.Domain.Primitives;

    public class Trade : BaseEntity
    {
        public Trade() { }

        public Trade(double value, EnumClientSector clientSector, DateTime nextPaymentDate) : base()
        {
            this.Value = value;
            this.ClientSector = clientSector;
            this.NextPaymentDate = nextPaymentDate;
        }

        public double Value { get; }
        public EnumClientSector ClientSector { get; }
        public DateTime NextPaymentDate { get; }
        public TradeCategory? Category { get; set; }

        public void DefineCategory(TradeCategory category) => this.Category = category;

    }
}
