using System.Numerics;
using WorkWithRefactoring.Common.Calculation;
using WorkWithRefactoring.Common.Enums;

namespace WorkWithRefactoring.Common.Interfaces
{
    public interface IAccount<T> where T : INumber<T>
    {
        /// <summary> Тип учетной записи</summary>
        public TypeEnum Type { get; set; }

        /// <summary>Баланс учетной записи</summary>
        public T Balance { get; set; }

        /// <summary>Процентная ставка</summary>
        public T Interest { get; }

        /// <summary>Метод расчета процентной ставки </summary>
        /// <param name="calculator"></param>
        public void Calculate(ICalculator calculator);
    }
}
