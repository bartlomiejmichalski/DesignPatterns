using Builder.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Builder.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void ShouldProcessOrderWithoutFailer()
        {
            // Given
            var order = new Order(Guid.NewGuid(), 100.0m, DateTime.Now);
            var orderService = OrderService.Create();
            // When 
            orderService.Execute(order);
            // Then
        }
    }
}
