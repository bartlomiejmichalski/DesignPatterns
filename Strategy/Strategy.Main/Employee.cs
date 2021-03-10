using Strategy.Main.Salary;

namespace Strategy.Main
{
    public class Employee
    {
        private ISalaryStrategy _salaryStrategy;
        public Employee(EmployeeType employeeType, ISalaryStrategy salaryStrategy)
        {
            Type = employeeType;
            _salaryStrategy = salaryStrategy;
        }

        public double CalculateNewSalary(
            double @base, 
            double sumOfIncomes, 
            double employeeIncome, 
            double importantCalculationFactor)
        {
            return _salaryStrategy.Calculate(
                @base, 
                sumOfIncomes, 
                employeeIncome, 
                importantCalculationFactor);
        }

        public EmployeeType Type { get; private set; }
    }
}