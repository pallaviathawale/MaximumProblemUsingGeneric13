namespace MaximumNumberUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 111, 222, 333, 422, 456 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
           // generic.MaxMethod();

            double[] doubleArray = { 11.1, 22.2, 3.33, 42.2, 455.5 };
            GenericMaximum<double> genericDouble= new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = {"apple", "peach", "banana" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();


        }
    }
}