using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy.Main;
using Strategy.Main.Salary;

namespace Strategy.Tests
{
   [TestClass]
    public class EmployeeSalaryTest
    {
        [TestMethod]
        public void ShouldCalculateSalaryForCeo()
        {
            // given
            var employee = EmployeeFactory.CreateCEO();
            // when
            var salary = employee.CalculateNewSalary(100, 100, 1, 2);
            // then
            Assert.AreEqual(324.0d, salary, 0.0001);
        }

        [TestMethod]
        public void ShouldCalculateSalaryForSales()
        {
            // given
            var employee = EmployeeFactory.CreateSales();
            // when
            double salary = employee.CalculateNewSalary(100, 100, 1, 2);
            // then
            Assert.AreEqual(103.0d, salary, 0.0001);
        }

        [TestMethod]
        public void ShouldCalculateSalaryForWorker()
        {
            // given
            var employee = EmployeeFactory.CreateWorker();
            // when
            double salary = employee.CalculateNewSalary(100, 100, 1, 2);
            // then
            Assert.AreEqual(102.0d, salary, 0.0001);
        }
    }
}
