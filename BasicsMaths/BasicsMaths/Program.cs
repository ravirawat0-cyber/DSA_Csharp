namespace BasicsMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countDigit = new CountDigit();

            Console.Write("Enter Digit to count: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(countDigit.GetDigitCount(input));

        }
    }
}
