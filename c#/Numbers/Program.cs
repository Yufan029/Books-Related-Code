namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = [1, 2, 3, 4, 5, 6];

            // outside the boundary
            //Console.WriteLine(intArr[^0]);

            // get the last one
            Console.WriteLine(intArr[^1]);
            //6

            // get the second last
            Console.WriteLine(intArr[^2]);
            //5

            // get from 0 to 5(not include)
            Console.WriteLine(string.Join(", ", intArr[0..5]));
            //1, 2, 3, 4, 5


            Console.WriteLine($"The min int is {int.MinValue}, and the max is {int.MaxValue}");
            //The min int is -2147483648, and the max is 2147483647

            int max = int.MaxValue;
            int maxNext = max + 1;
            Console.WriteLine($"What is max + 1: {maxNext}");
            //What is max + 1: -2147483648

            int min = int.MinValue;
            int minLower = min - 1;
            Console.WriteLine($"what is min - 1: {minLower}");
            //what is min - 1: 2147483647

            double doubleMax = double.MaxValue;
            double doubleMin = double.MinValue;
            Console.WriteLine($"The range of double is {doubleMin} to {doubleMax}");
            //The range of double is -1.7976931348623157E+308 to 1.7976931348623157E+308

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            //0.3333333333333333

            // smaller range than double, but greater precision
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {decimalMin} to {decimalMax}");
            //The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            //0.3333333333333333333333333333
        }
    }
}
