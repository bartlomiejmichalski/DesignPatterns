using System;
using Strategy.Main.Salary;

namespace Strategy.Main
{
    public class BusinessLogic
    {
        public void CalculateWorkersSalary(
            int numberOfWorkers, 
            double @base, 
            double sumOfIncomes, 
            double employeeIncome, 
            double importantCalculationFactor)
        {
            ISalaryStrategy salaryStrategy = new WorkerStrategy();
            var newSalary = salaryStrategy.Calculate(
                @base, 
                sumOfIncomes, 
                employeeIncome, 
                importantCalculationFactor);
            Console.WriteLine($"New simulated salary is {newSalary * numberOfWorkers}");
        }
    }
}