namespace Strategy.Main
{
    public class SalesStrategy: ISalaryStrategy
    {
        public double Calculate(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor)
        {
            // 1. 
            // 2.
            // 3.
            return @base + sumOfIncomes * 0.01 + importantCalculationFactor * employeeIncome;
        }
    }
}