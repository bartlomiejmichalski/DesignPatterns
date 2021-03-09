namespace Strategy.Main.Salary
{
    public class CEOStrategy: ISalaryStrategy
    {
        public double Calculate(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor)
        {
            // 1. 
            // 2.
            // 3.
            // 5.
            return @base + sumOfIncomes * 0.2 + 200 + importantCalculationFactor * employeeIncome * 2;
        }
    }
}