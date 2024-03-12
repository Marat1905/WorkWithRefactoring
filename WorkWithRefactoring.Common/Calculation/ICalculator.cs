using System.Numerics;
using WorkWithRefactoring.Common.Interfaces;

namespace WorkWithRefactoring.Common.Calculation
{
    public interface ICalculator
    {
        /// <summary>Расчет процентной ставки </summary>
        T CalculateInterest<T>(IAccount<T> account) where T : INumber<T>;
    }
}
