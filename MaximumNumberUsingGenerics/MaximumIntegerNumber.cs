using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGenerics
{
    internal class MaximumIntegerNumber
    {
        public static int MaximumIntegerCheck(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if(secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber)>0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            throw new Exception("firstNumber, secondNumber, thirdNumber are same");
        }

    }
}
