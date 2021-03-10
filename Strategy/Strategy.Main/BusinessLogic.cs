using System;
using Strategy.Main.Salary;

namespace Strategy.Main
{
    public class BusinessLogic
    {
        private ISalaryStrategyFactory _salaryStrategyFactory;

        public BusinessLogic(ISalaryStrategyFactory salaryStrategyFactory)
        {
            _salaryStrategyFactory = salaryStrategyFactory;
        }

        public void CalculateWorkersSalary(
            int numberOfWorkers, 
            double @base, 
            double sumOfIncomes, 
            double employeeIncome, 
            double importantCalculationFactor)
        {
            ISalaryStrategy salaryStrategy = _salaryStrategyFactory.CreateStrategy();
            var newSalary = salaryStrategy.Calculate(
                @base, 
                sumOfIncomes, 
                employeeIncome, 
                importantCalculationFactor);
            Console.WriteLine($"New simulated salary is {newSalary * numberOfWorkers}");
        }
    }
}