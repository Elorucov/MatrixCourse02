
namespace W2_Conditions {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            byte age;
            bool ageParsed = byte.TryParse(ageInput, out age);
            if (ageParsed) {
                Console.Write("Enter your salary: ");
                string salaryInput = Console.ReadLine();

                int salary;
                bool salaryParsed = int.TryParse(salaryInput, out salary);
                if (salaryParsed) {
                    Console.Write("Enter your gender: ");
                    string gender = Console.ReadLine();

                    if (gender == "male" || gender == "female") {
                        CheckCandidate(age, salary, gender);
                    } else {
                        Console.WriteLine("Wrong gender!");
                    }
                } else {
                    Console.WriteLine("Wrong salary!");
                }
            } else {
                Console.WriteLine("Wrong age!");
            }
        }

        static void CheckCandidate(byte age, int salary, string gender) {
            if (age > 18 && salary >= 1000) {
                Console.WriteLine(gender == "female" ? "You are a suitable lady in the labor market" : "You are a suitable candidate in the labor market");
            } else if (age < 18 && salary < 1000) {
                Console.WriteLine($"You have not yet reached working age");
            } else {
                Console.WriteLine($"No relevant data available");
            }
        }
    }
}