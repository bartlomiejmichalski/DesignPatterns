using System;

namespace Strategy.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            new BusinessLogic().CalculateWorkersSalary(100, 100, 100, 1, 2);
        }
    }
}
