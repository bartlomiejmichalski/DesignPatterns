using Strategy.Main.Salary;

namespace Strategy.Main
{
    public class WorkerSalaryStrategyFactory : ISalaryStrategyFactory
    {
        public ISalaryStrategy CreateStrategy()
        {
            //1. AvgSalary from db
            double avgSalary = 103.73;
            return new WorkerStrategy(avgSalary);
        }
    }

    public class CEOSalaryStrategyFactory : ISalaryStrategyFactory
    {
        public ISalaryStrategy CreateStrategy()
        {
            //1. AvgSalary from db
            return new CEOStrategy();
        }
    }
}