using System;

namespace Builder.Main
{
    public class BusinessLogic 
    {
        public void ExecuteOrder66()
        {
            //1. Create order 
            var order = 
            Order
            .CreateBuilder()
            .WithCustomerId(Console.ReadLine())
            .WithAmount(Console.ReadLine())
            .Build();

            //2. Process order 
            var orderService = OrderService.Create();
            orderService.Execute(order);
            Console.WriteLine("End of processing Order!");
        }
    }
}
