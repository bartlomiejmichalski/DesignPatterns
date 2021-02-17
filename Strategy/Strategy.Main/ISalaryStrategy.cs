namespace Strategy.Main
{
    public interface ISalaryStrategy 
    {
        double Calculate(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor);
    }
}