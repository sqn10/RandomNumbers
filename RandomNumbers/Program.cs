namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Please pick a program to run, out of these:");
            Console.WriteLine("1. Random Number Generator");
            Console.WriteLine("2. Dice Roller");
            Console.WriteLine("3. Magic 8 ball");
            Int32.TryParse(Console.ReadLine(), out choice);
            if (choice == 1)
            {
                Console.Clear();
                Task1();
            }
            else if (choice == 2)
            {
                Console.Clear();
                Task3();
            }
            else if (choice == 3)
            {
                Console.Clear();
                Task4();
            }
            else
            {
                Console.WriteLine("Not valid input. Try again. Press ENTER to exit.");
                Console.ReadLine();
            }
        }
        public static void Task1()
        {
            int rangeNum1, rangeNum2;

            Random generator = new Random();

            Console.WriteLine("I will give you random numbers within a range. You need to provide the numbers of the range. Make the second bigger than the first.");

            Console.WriteLine();

            Console.WriteLine("Enter the first number");
            Int32.TryParse(Console.ReadLine(), out rangeNum1);

            Console.WriteLine("Enter the second number");
            Int32.TryParse(Console.ReadLine(), out rangeNum2);

            if (rangeNum1 >= rangeNum2)
            {
                Console.WriteLine("You can't do that!");
            }
            else
            {
                Console.Write(generator.Next(rangeNum1, rangeNum2) + " ");
                Console.Write(generator.Next(rangeNum1, rangeNum2) + " ");
                Console.Write(generator.Next(rangeNum1, rangeNum2) + " ");
                Console.Write(generator.Next(rangeNum1, rangeNum2) + " ");
            }
        }

        // Task 2: We never did a guessing game in Topic 5.

        public static void Task3()
        {
            Random generator = new Random();
            int diceResult = generator.Next(1, 7);
            int diceResult2 = generator.Next(1, 7);
            int diceSum = diceResult + diceResult2;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dice roller. Computing...");
            Thread.Sleep(1000);
            Console.WriteLine("Please wait...");
            Thread.Sleep(1000);
            Console.Write("Downloading more RAM");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.WriteLine("."); Console.WriteLine();
            Thread.Sleep(1000);

            Console.WriteLine("Your dice are " + diceResult + " and " + diceResult2 + ".");

            Console.WriteLine("The sum is: " + diceSum + ".");
        }
        public static void Task4()
        {
            string answer;

            Console.WriteLine("MAGIC 8 BALL!");
            Console.WriteLine("Ask a question, and I will come up with an answer...");
            answer = Console.ReadLine();
        }
    }
}
