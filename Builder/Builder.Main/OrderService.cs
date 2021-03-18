namespace Builder.Main
{
    public class OrderService
    {
        public static OrderService Create() => new OrderService();

        public void Execute(Order order)
        {
            //1. very important stuff with order :) Believe me :) 
        }
    }
}
