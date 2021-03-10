using System;

namespace Strategy.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            new BusinessLogic(new CEOSalaryStrategyFactory()).CalculateWorkersSalary(100, 100, 100, 1, 2);
        }
    }
}
