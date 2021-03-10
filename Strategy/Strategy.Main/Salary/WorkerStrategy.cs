namespace Strategy.Main.Salary
{
    public class WorkerStrategy : ISalaryStrategy
    {
        private double _avgSalary;

        public WorkerStrategy(double avgSalary = 0.00)
        {
            _avgSalary = avgSalary;
        }

        public double Calculate(
            double @base, 
            double sumOfIncomes,
             double employeeIncome, 
             double importantCalculationFactor)
        {
            if (_avgSalary > 175.00)
            {
                return 0.00;
            }
            return @base + employeeIncome * importantCalculationFactor;
        }
    }
}