namespace CreditSuisse.Domain.Primitives
{
    using System;

    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity() => this.Id = Guid.NewGuid();
    }
}
