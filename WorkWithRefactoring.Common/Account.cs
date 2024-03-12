using System.Numerics;
using WorkWithRefactoring.Common.Calculation;
using WorkWithRefactoring.Common.Enums;
using WorkWithRefactoring.Common.Interfaces;

namespace WorkWithRefactoring.Common
{
    public class Account<T>:IAccount<T> where T : INumber<T>
    {
        /// <summary> Тип учетной записи</summary>
        public TypeEnum Type { get; set; }

        /// <summary>Баланс учетной записи</summary>
        public T Balance { get; set; }

        /// <summary>Процентная ставка</summary>
        public T Interest { get; private set; }

        public Account(TypeEnum type,T balance)
        {
            Type = type;
            Balance = balance;
        }

        public void Calculate(ICalculator calculator)
        {
            Interest = calculator.CalculateInterest(this);
        }
    }
}
