namespace Algorithm_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Algorithm-Problems!!!");
            Console.WriteLine("---------------------------------------------------------------------");
            while (true)
            {
                Console.WriteLine("\n 1. Program to return all permutations of a string");
                Console.WriteLine(" 2. Binary Search the word from word list");
                Console.WriteLine(" 3. Insertion sort");
                Console.WriteLine(" 4. Bubble sort");
                Console.WriteLine(" 5. Merge sort");
                Console.WriteLine(" 6. Anagram Detection");
                Console.WriteLine(" 7. Prime numbers in the range 0 - 1000");
                Console.WriteLine(" 8. Prime numbers in 0 - 1000 that are anagram and palindrome");
                Console.WriteLine(" 9. Find your number");
                Console.WriteLine("10. Customize message demonstration using String function and RegEx");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PermutationsOfString permute = new PermutationsOfString();
                        permute.Driver();
                        break;
                    case 2:
                        List<string> wordArray = new List<string> { "Application", "Bread", "Cake", "Dog", "Eggs", "Pizza", "Roti", "Sabzi" };
                        BinarySearchWord<string> binarySearchWord = new BinarySearchWord<string>();
                        binarySearchWord.DriverMethod(wordArray);
                        break;
                    case 3:
                        InsertionSort<int> insertionSort = new InsertionSort<int>();
                        insertionSort.Insertion();
                        break;
                    case 4:
                        BubbleSort<int> bs = new BubbleSort<int>();
                        bs.Bubble();
                        break;
                    case 5:
                        Console.Write("Enter integers values separated by spaces to sort : ");
                        //Taking input from user and storing it to strings array of type string
                        string[] strings = Console.ReadLine().Split();

                        int[] sortArray = new int[strings.Length];
                        //Converting each string value in strings array to integer type and storing it to sortArray for further calculation
                        for (int i = 0; i < strings.Length; i++)
                        {
                            sortArray[i] = Convert.ToInt32(strings[i]);
                        }
                        MergeSort<int> mergeSort = new MergeSort<int>();
                        mergeSort.Driver(sortArray);
                        break;
                    case 6:
                        AnagramDetection anagramDetection = new AnagramDetection();
                        anagramDetection.Anagram();
                        break;
                    case 7:
                        PrimesInRange primesInRange = new PrimesInRange();
                        primesInRange.Prime();
                        break;
                    case 8:
                        ExtendedPrime extendedPrime = new ExtendedPrime();
                        extendedPrime.Prime();
                        break;
                    case 9:
                        FindYourNumber findYourNumber = new FindYourNumber();
                        findYourNumber.Find();
                        break;
                    case 10:
                        CustomizeMessage messageDemonstration = new CustomizeMessage();
                        messageDemonstration.Message();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please choose the correct option");
                        break;
                }
            }
        }
    }
}