
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
                    Console.Write("Enter your sex: ");
                    string sex = Console.ReadLine();

                    if (sex == "male" || sex == "female") {
                        CheckCandidate(age, salary, sex);
                    } else {
                        Console.WriteLine("Wrong sex!");
                    }
                } else {
                    Console.WriteLine("Wrong salary!");
                }
            } else {
                Console.WriteLine("Wrong age!");
            }
        }

        static void CheckCandidate(byte age, int salary, string sex) {
            if (age > 18 && salary >= 1000) {
                Console.WriteLine(sex == "female" ? "You are a suitable woman in the labor market" : "You are a suitable candidate in the labor market");
            } else if (age < 18 && salary < 1000) {
                Console.WriteLine($"You have not yet reached working age");
            } else {
                Console.WriteLine($"No relevant data available");
            }
        }
    }
}