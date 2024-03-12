using WorkWithRefactoring.Common;
using WorkWithRefactoring.Common.Calculation;
using WorkWithRefactoring.Common.Enums;
using WorkWithRefactoring.Common.Interfaces;

namespace WorkWithRefactoring.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new CustomCalculator();

            IAccount<double> account = new Account<double>(TypeEnum.Salary,500);

            account.Calculate(calculator);

            Console.WriteLine(account.Interest);
        }
    }
}
