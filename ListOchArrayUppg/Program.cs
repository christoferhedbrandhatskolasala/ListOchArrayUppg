using System.Xml.Linq;

namespace ListOchArrayUppg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sum
            int[] testNumbers = { 1, 2, 42 }; // kan ändras, ska ändå bli rätt svar
            Console.WriteLine("Demonstration av Sum:");
            Console.WriteLine("Summan av testdatan är: " + Sum(testNumbers));
            Console.WriteLine();

            // Max
            int[] testNumbers2 = { 1, 2, 42, 6, 1 };
            Console.WriteLine("Demonstration av Max:");
            Console.WriteLine("Största talet är: " + Max(testNumbers2));
            Console.WriteLine();

            // Contains
            string[] testNames = { "Anna", "Bertil", "Cesar" };
            Console.WriteLine("Demonstration av Contains:");
            Console.WriteLine("Contains(Bertil): " + Contains(testNames, "Bertil")); // true
            Console.WriteLine("Contains(David): " + Contains(testNames, "David")); // false
            Console.WriteLine();

            // Swap
            int[] swapTestData = { 8, 4, 6, 9 };
            Console.WriteLine("Demonstration av Swap:");
            Console.WriteLine("Före: " + string.Join(",", swapTestData));
            Swap(1, 3, swapTestData); // ska fungera med olika index!
            Console.WriteLine("Efter: " + string.Join(",", swapTestData));
            Console.WriteLine();

            // Concatenate
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));


        }

        public static int Sum(int[] numbers)
        {
            int result = 0;
            foreach (int n in numbers)
            {
                result += n;
            }
            return result;
        }

        public static int Max(int[] numbers)
        {
            int result = numbers[0];
            foreach (int number in numbers) {
                if (number > result)
                {
                    result = number;
                }
            }

            return result;
        }

        public static bool Contains(string[] names, string name)
        {
            foreach (string s in names)
            {
                if (s == name) return true;
            }
            return false;
        }

        public static void Swap(int index1, int index2, int[] numbers)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }

        public static string[] Concatenate(string[] part1, string[] part2)
        {
            string[] result = new string[part1.Length + part2.Length];

            for (int i = 0; i < part1.Length; i++)
            {
                result[i] = part1[i];
            }

            for (int i = 0; i < part2.Length; i++)
            {
                result[part1.Length + i] = part1[i];
            }

            return result;
        }
    }
}