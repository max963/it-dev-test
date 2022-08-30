using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditSuisse.Domain.Primitives;

namespace CreditSuisse.Domain.Entities
{
    public class TradeCategory : BaseEntity
    {
        public TradeCategory() : base() { }
        public string CategoryName { get; set; }
    }
}
