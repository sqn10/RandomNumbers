namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task3();
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
            // do better
            Random generator = new Random();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dice roller. Computing...");
            Thread.Sleep(1000);

        }
    }
}
