namespace MaximumNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Integer Number:");
            int output = MaximumIntegerNumber.MaximumIntegerCheck(11, 22, 33);
            Console.WriteLine(output);
            Console.WriteLine("Maximum Float Number:");
            double Doubleoutput = MaximumIntegerNumber.MaximumFloatCheck(11.11, 22.33, 33.44);
            Console.WriteLine(Doubleoutput);
        }
    }
}