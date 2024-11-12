namespace W1_CastingConverting {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter an int value: ");
            string intInput = Console.ReadLine();
            CheckIntInput(intInput);

            Console.Write("Enter a double value: ");
            string doubleInput = Console.ReadLine();
            CheckDoubleValue(doubleInput);

            Console.Write("Enter a string value: ");
            string stringValue = Console.ReadLine();
        }

        static void CheckIntInput(string intInput) {
            int value;
            bool parsed = int.TryParse(intInput, out value);
            if (parsed) {
                double castValue = value;
                Console.WriteLine("Your input parsed and converted to double value: " + castValue);
            } else {
                Console.WriteLine("Wrong input!");
            }
        }

        private static void CheckDoubleValue(string doubleInput) {
            double value;
            bool parsed = double.TryParse(doubleInput, out value);

            if (parsed) {
                int castValue = (int)value;
                Console.WriteLine("Your input parsed and converted to int value: " + castValue);

                string doubleToString = value.ToString();
                string intToString = castValue.ToString();
                if (doubleToString != intToString) {
                    Console.WriteLine($"Precision loss: {doubleToString} != {intToString}");
                }
            } else {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}