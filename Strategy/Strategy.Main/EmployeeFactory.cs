using Strategy.Main.Salary;

namespace Strategy.Main
{
    public class EmployeeFactory
    {
        public static Employee CreateCEO()
        {
            return new Employee(EmployeeType.CEO, new CEOStrategy());
        }

        public static Employee CreateSales()
        {
            return new Employee(EmployeeType.Sales, new SalesStrategy());
        }

        public static Employee CreateWorker()
        {
            return new Employee(EmployeeType.Worker, new WorkerStrategy());
        } 
    }
}