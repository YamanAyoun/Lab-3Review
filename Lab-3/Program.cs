namespace Lab_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            SaveTextInFile();
        }

        public static int GetProduct()
        {

            Console.WriteLine("Please enter 3 numbers: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            if (numbers.Length <= 2)
            {
                return 0;
            }

            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(numbers[i], out int num))
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

        public static int avarageNumber(string[] arr, int size)
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
            int maxDuplic = 0;

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
                    most = count;
                    maxDuplic = arr[i];
                }
            }

            return maxDuplic;
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


    }
}