using System.Diagnostics.Metrics;

namespace Lab_3
{
    public class Program
    {
        static void Main(string[] args)
        {

            //SaveTextInFile();
            //Challenge8();

            string[] wordList = AnalyzeSentence();
            foreach (string wordInfo in wordList)
            {
                Console.WriteLine(wordInfo);
            }
            


        }

        public static int GetProduct()
        {

            Console.WriteLine("Please enter 3 numbers: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            

            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                if (numbers.Length < 3)
                {
                    product = 0;
                }
                else if (int.TryParse(numbers[i], out int num))
                {
                    product *= num;
                }
                else
                {
                     product *= 1;
                }
            }

            Console.WriteLine("The product of these 3 numbers is: " + product);
            return product;
        }

        public static void Challenge2()
        {
            Console.WriteLine("Please enter a number between 2-10:");
            string userInput = Console.ReadLine();
            int userInputInt;

            try
            {
                userInputInt = Convert.ToInt32(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Thats not a number, Enter a number between 2-10:");
                userInput = Console.ReadLine();
                userInputInt = Convert.ToInt32(userInput);
            }

            int[] arr = new int[userInputInt];

            for (int i = 0; i < userInputInt; i++)
            {
                Console.WriteLine($"{i + 1} of {userInputInt} - Enter a number:");
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You should Enter a Number");
                }
            }

            Console.WriteLine("Avarage: " + avarageNumber(arr, userInputInt));
        }

        public static int avarageNumber(int[] arr, int size)
        {

            int[] num = new int[size];


            int sum = 0;
            int avg = 0;
            if (size == 0)
            {

                return avg;
            }

            for (int i = 0; i < size; i++)


            {
                num[i] = Convert.ToInt32(arr[i]);
                if (num[i] < 0)
                {
                    return -1;
                }

                sum = num[i] + sum;
            }
            avg = sum / size;
            return avg;



        }
        static void DrawPattern(int n)
        {
            int space = n;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= space; j++)
                    Console.Write(" ");

                for (int j = 0; j < i; j++)
                    Console.Write("* ");

                Console.WriteLine(" ");
                space--;
            }

            space = 1;

            for (int i = n; i > 0; i--)
            {

                for (int j = 0; j < space; j++)
                    Console.Write(" ");

                for (int j = 0; j < i; j++)
                    Console.Write("* ");

                Console.WriteLine(" ");
                space++;
            }
        }

        public static int numberMost(int[] arr)
        {
            int most = 0;
            int maxDuplic = arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (most < count)
                {
                    maxDuplic = arr[i];
                    most = count;
                
                }
                

            }

            return maxDuplic;
        }

        public static int maximumValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void SaveTextInFile()
        {
            Console.WriteLine("Add Text to save");
            string words = Console.ReadLine();

            string path = "../../../words.txt";



            File.WriteAllText(path, words);
        }
        public static void ReadWordsFile()
        {
            string path = "../../../words.txt";
            string fileData = File.ReadAllText(path);


            Console.WriteLine(fileData);
        }

        public static void Challenge8()
        {
            string path = "../../../words.txt";
            string fileContent = File.ReadAllText(path);


            File.WriteAllText(path, "");
            Console.WriteLine("The new content is:");
            string[] newfileContent = File.ReadAllLines(path);
            for (int i = 0; i < newfileContent.Length; i++)
                Console.WriteLine(newfileContent[i]);

        }

        public static string[] AnalyzeSentence()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            // Split the sentence into words by whitespace
            string[] words = sentence.Split(' ');

            // Create an array to store the word and its length
            string[] wordLengths = new string[words.Length];

            // Process each word and store the word and its length in the array
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int length = word.Length;
                wordLengths[i] = $"{word}: {length}";
            }

            return wordLengths;
        }



    }
}