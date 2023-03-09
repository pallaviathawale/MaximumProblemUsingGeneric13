namespace MaximumNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Maximum Integer Number:");
            // int output = MaximumIntegerNumber.MaximumIntegerCheck(11, 22, 33);
            // Console.WriteLine(output);

            //Console.WriteLine("Maximum Float Number:");
            //double Doubleoutput = MaximumIntegerNumber.MaximumFloatCheck(11.11, 22.33, 33.44);
            //Console.WriteLine(Doubleoutput);

            //Console.WriteLine("Maximum String Number:");
            //string Stringoutput = MaximumIntegerNumber.MaximumStringCheck("Apple","Peach","Banana");
            //Console.WriteLine(Stringoutput);
           // int[] intArray = { 1, 2, 3 };
            GenericMaximum<int> generic = new GenericMaximum<int>(1, 2, 3);
            int int_max=generic.MaxMethod();
            Console.WriteLine("Maximum integer number is:" + int_max);

           // double[] doubleArray = { 11.11, 22.44, 33.22 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(11.22, 22.22, 33.33);
            double double_max=genericDouble.MaxMethod();
            Console.WriteLine("Maximum Float number is:" + double_max);

            //string[] stringArray = { "111", "222", "333" };
            GenericMaximum<string> genericString = new GenericMaximum<string>("apple", "peach", "banana");
            String x=genericString.MaxMethod();
            Console.WriteLine("Maximum string number is " +x );
        }
    }
}