using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGenerics
{
    public class GenericMaximum<T> where T : IComparable //createclass
    {
        public T[] value; // accepting array values
        public GenericMaximum(T[] value) //method-parameterised constructor
        {
            this.value = value; 
        }   
        public T[] Sort(T[] values) //accept generic datatype and sort that values
        {
            Array.Sort(values); //inbuilt method which sort array
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        //public T MaxMethod()
        //{
        //    var max = MaxValue(this.value);
        //    return max;
        //}
        public void PrintMaxValue() //method to print maximum number
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is: " + max);

        }

    }

}
