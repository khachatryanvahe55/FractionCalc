namespace FractionCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MixedNumber a = new MixedNumber(2, 1, 2); // 2 1/2
            MixedNumber b = new MixedNumber(1, 3, 4); // 1 3/4

            MixedNumber sum = a + b;
            MixedNumber difference = a - b;
            MixedNumber product = a * b;
            MixedNumber quotient = a / b;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}