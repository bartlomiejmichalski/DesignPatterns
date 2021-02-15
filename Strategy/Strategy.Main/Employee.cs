namespace Strategy.Main
{
    public class Employee
    {
        public Employee(EmployeeType employeeType)
        {
            Type = employeeType;
        }

        public double CalculateNewSalary(double @base, double sumOfIncomes, double employeeIncome, double importantCalculationFactor)
        {
            switch (Type)
            {
                case EmployeeType.CEO:
                    // 1. 
                    // 2.
                    // 3.
                    // 5.
                    return @base + sumOfIncomes * 0.2 + 200 + importantCalculationFactor * employeeIncome * 2;
                case EmployeeType.Sales:
                    // 1. 
                    // 2.
                    // 3.
                    return @base + sumOfIncomes * 0.01 + importantCalculationFactor * employeeIncome;
                case EmployeeType.Worker:
                    return @base + employeeIncome * importantCalculationFactor;
                default:
                    return 0.00;
            }
        }

        public EmployeeType Type { get; private set; }
    }
}