namespace Strategy.Main.Salary
{
    public interface ISalaryStrategy 
    {
        double Calculate(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor);
    }
}