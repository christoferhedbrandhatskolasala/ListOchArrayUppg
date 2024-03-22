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
            Console.WriteLine();

            // Reverse
            int[] reverseTestData = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Demonstration av Reverse:");
            Console.WriteLine("Före: " + string.Join(",", reverseTestData));
            Reverse(reverseTestData);
            Console.WriteLine("Efter: " + string.Join(",", reverseTestData));
            Console.WriteLine();

            // Rotate
            string[] rotateTestData = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Demonstration av Rotate:");
            Console.WriteLine("Före: " + string.Join(",", rotateTestData));
            string[] rotateTestDataResult = Rotate(rotateTestData, 2);
            Console.WriteLine("Efter: " + string.Join(",", rotateTestDataResult));
            Console.WriteLine();

            // RotateInPlace
            Console.WriteLine("Demonstration av RotateInPlace:");
            Console.WriteLine("Före: " + string.Join(",", rotateTestData));
            RotateInPlace(rotateTestData, 2);
            Console.WriteLine("Efter: " + string.Join(",", rotateTestData));
            Console.WriteLine();

            // BubbleSort
            int[] bubbleSortTestData = { 8, 3, 4, 7, 1, 4, 6, 3 };
            Console.WriteLine("Demonstration av BubbleSort:");
            Console.WriteLine("Före: " + string.Join(",", bubbleSortTestData));
            BubbleSort(bubbleSortTestData);
            Console.WriteLine("Efter: " + string.Join(",", bubbleSortTestData));
            Console.WriteLine();

            // Intersection
            string[] intersectionSet1 = { "a", "b", "c", "d", "e" };
            string[] intersectionSet2 = { "h", "d", "w", "s", "a" };
            Console.WriteLine("Demonstration av Intersection:");
            Console.WriteLine("Set 1: " + string.Join(",", intersectionSet1));
            Console.WriteLine("Set 2: " + string.Join(",", intersectionSet2));
            List<string> intersectionResult = Intersection(intersectionSet1, intersectionSet2);
            Console.WriteLine("Resultat: " + string.Join(",", intersectionResult));
            Console.WriteLine();

            // Unique
            string[] uniqueTestData = { "a", "b", "c", "d", "a", "a", "c" };
            Console.WriteLine("Demonstration av Unique:");
            Console.WriteLine("Testdata: " + string.Join(",", uniqueTestData));
            List<string> uniqueResult = Unique(uniqueTestData);
            Console.WriteLine("Resultat: " + string.Join(",", uniqueResult));
            Console.WriteLine();
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

            // alternativ lösning med tuplar
            // (numbers[index1], numbers[index2]) = (numbers[index2], numbers[index1]);
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
                result[part1.Length + i] = part2[i];
            }

            return result;
        }

        public static void Reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                Swap(i, numbers.Length - 1 - i, numbers);
            }
        }

        public static string[] Rotate(string[] strings, int n)
        {
            string[] result = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                result[(i + n) % strings.Length] = strings[i];
            }

            return result;
        }

        public static void RotateOneStep(string[] strings)
        {
            string last = strings[strings.Length - 1];

            for (int i = strings.Length - 1; i > 0 ; i--)
            {
                strings[i] = strings[i - 1];
            }

            strings[0] = last;
        }

        public static void RotateInPlace(string[] strings, int n)
        {
            for (int i = 0; i < n; i++)
            {
                RotateOneStep(strings);
            }
        }

        public static void BubbleSort(int[] numbers)
        {
            bool updateAgain = true;

            while (updateAgain)
            {
                updateAgain = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Swap(i, i + 1, numbers);
                        updateAgain = true;
                    }
                }
            }
        }

        public static List<string> Intersection(string[] set1, string[] set2)
        {
            List<string> result = new List<string>();
            foreach (string s in set1)
            {
                if (Contains(set2, s))
                {
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<string> Unique(string[] strings)
        {
            List<string> result = new List<string>();

            foreach (string s1 in strings)
            {
                int count = 0;
                foreach (string s2 in strings)
                {
                    if (s1 == s2)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    result.Add(s1);
                }
            }

            return result;
        }
    }
}