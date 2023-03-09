namespace MaximumNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Integer Number:");
            int output = MaximumIntegerNumber.MaximumIntegerCheck(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}