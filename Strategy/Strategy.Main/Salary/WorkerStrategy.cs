namespace Strategy.Main.Salary
{
    public class WorkerStrategy : ISalaryStrategy
    {
        public double Calculate(
            double @base, 
            double sumOfIncomes,
             double employeeIncome, 
             double importantCalculationFactor)
        {
            return @base + employeeIncome * importantCalculationFactor;
        }
    }
}