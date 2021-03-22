using System;

namespace Builder.Main
{
    

    public class Order
    {
        internal class OrderBuilder
        {
            private Guid _customerId;
            private decimal _amount;
            private DateTime _createdAt;

            internal OrderBuilder WithCustomerId(string customerId)
            {
                _customerId = Guid.Parse(customerId);
                return this;
            }

            internal OrderBuilder WithAmount(string amount)
            {
                _amount = decimal.Parse(amount);
                return this;
            }
            internal OrderBuilder WithCreatedAt(string createdAt)
            {
                _createdAt = DateTime.Parse(createdAt);
                return this;
            }
            internal Order Build()
            {
                if (_createdAt == null)
                {
                    _createdAt = DateTime.Now;
                }
                return new Order(_customerId, _amount, _createdAt);
            }
        }
        public Order(Guid customerId, decimal amount, DateTime createdAt)
        {
            CustomerId = customerId;
            Amount = amount;
            CreatedAt = createdAt;
        }

        internal static OrderBuilder CreateBuilder()
        {
            return new OrderBuilder();
        }

        public Guid CustomerId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
