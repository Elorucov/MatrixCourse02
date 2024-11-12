
namespace W3_LogicalComparisonTernaryOperations {
    internal class Program {
        static void Main(string[] args) {
            int first = RequestNumber("Enter first number: ");
            int second = RequestNumber("Enter second number: ");
            int third = RequestNumber("Enter third number: ");

            if (first <= 0 || second <= 0 || third <= 0) {
                Console.WriteLine("Unable to calculate result");
            } else if (first > 10 && second > 10 && third > 10) {
                CalculateSumOfSquare(first, second, third);
            }
            int max = first > second && first > third ? first
                : second > first && second > third ? second
                : third;
            Console.WriteLine("Maximal value is " + max);
        }

        static int RequestNumber(string output) {
            Console.Write(output);
            string input = Console.ReadLine();
            int value;
            int.TryParse(input, out value);
            return value;
        }

        private static void CalculateSumOfSquare(int first, int second, int third) {
            double firstSquare = Math.Pow(first, 2);
            double secondSquare = Math.Pow(second, 2);
            double thirdSquare = Math.Pow(third, 2);
            double sum = firstSquare + secondSquare + thirdSquare;
            Console.WriteLine($"The sum of squares of the numbers you entered: {firstSquare} + {secondSquare} + {thirdSquare} = {sum}");
        }
    }
}
