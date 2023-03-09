using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGenerics
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstNumber, secondNumber, thirdNumber;
        public GenericMaximum(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }

        public static T MaxNumber(T firstNumber, T secondNumber, T thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) >= 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo((T)firstNumber) >= 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) >= 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) >= 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) >= 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) >= 0)

            {
                return thirdNumber;
            }
            return default;
        }
        //public static double MaximumFloatCheck(double firstNumber, double secondNumber, double thirdNumber)
        //{
        //    if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
        //    {
        //        return firstNumber;
        //    }
        //    if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
        //    {
        //        return secondNumber;
        //    }
        //    if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
        //    {
        //        return thirdNumber;
        //    }
        //    throw new Exception("firstNumber, secondNumber, thirdNumber are same");
        //}

        //public static string MaximumStringCheck(string firstNumber, string secondNumber, string thirdNumber)
        //{
        //    if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
        //    {
        //        return firstNumber;
        //    }
        //    if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
        //    {
        //        return secondNumber;
        //    }
        //    if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
        //    {
        //        return thirdNumber;
        //    }
        //    throw new Exception("firstNumber, secondNumber, thirdNumber are same");
        //}
        public T MaxMethod()
        {
            T max = GenericMaximum<T>.MaxNumber(this.firstNumber, this.secondNumber, this.thirdNumber);
            return max;
        }
    }
}
