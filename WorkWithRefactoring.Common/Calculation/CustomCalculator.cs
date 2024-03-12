using System;
using System.Numerics;
using WorkWithRefactoring.Common.Interfaces;

namespace WorkWithRefactoring.Common.Calculation
{
    public class CustomCalculator : ICalculator
    {
        public T CalculateInterest<T>(IAccount<T> account ) where T:INumber<T>
        {
            T result = default(T);

            switch (account.Type)
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                case Enums.TypeEnum.Ordinary:
                    
                    result = account.Balance * (T)Convert.ChangeType(0.4, typeof(T));

                    if (account.Balance < (T)Convert.ChangeType(1000, typeof(T)))
                        result -= account.Balance * (T)Convert.ChangeType(0.2, typeof(T));

                    if (account.Balance >= (T)Convert.ChangeType(1000, typeof(T)))
                        result -= account.Balance * (T)Convert.ChangeType(0.4, typeof(T));
                    break;
                // расчет процентной ставки зарплатного аккаунта по правилам банка
                case Enums.TypeEnum.Salary:
                    result = account.Balance * (T)Convert.ChangeType(0.5, typeof(T));
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
