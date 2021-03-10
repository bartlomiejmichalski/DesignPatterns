using Strategy.Main.Salary;

namespace Strategy.Main
{
    public interface ISalaryStrategyFactory
    {
        ISalaryStrategy CreateStrategy();
    }
}