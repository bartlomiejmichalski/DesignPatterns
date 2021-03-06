using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy.Main;

namespace Strategy.Tests
{
   [TestClass]
    public class EmployeeSalaryTest
    {
        [TestMethod]
        public void ShouldCalculateSalaryForCeo()
        {
            // given
            var employee = new Employee(EmployeeType.CEO);
            // when
            var salary = employee.CalculateNewSalary(100, 100, 1, 2);
            // then
            Assert.AreEqual(324.0d, salary, 0.0001);
        }

        [TestMethod]
        public void ShouldCalculateSalaryForSales()
        {
            // given
            var employee = new Employee(EmployeeType.Sales);
            // when
            double salary = employee.CalculateNewSalary(100, 100, 1, 2);
            // then
            Assert.AreEqual(103.0d, salary, 0.0001);
        }

        [TestMethod]
        public void ShouldCalculateSalaryForWorker()
        {
            // given
            var employee = new Employee(EmployeeType.Worker);
            // when
            double salary = employee.CalculateNewSalary(100, 100, 1, 2);
            // then
            Assert.AreEqual(102.0d, salary, 0.0001);
        }
    }
}
