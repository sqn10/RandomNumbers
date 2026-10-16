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
        public static void Loader(string text, int delay = 2000)
        {
            Console.Write(text);
            Thread.Sleep(delay);
            Console.Write(".");
            Thread.Sleep(delay);
            Console.Write(".");
            Thread.Sleep(delay);
            Console.WriteLine("."); Console.WriteLine();
            Thread.Sleep(delay);
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

            Loader("Dice roller. Computing", 500);
            Loader("Downloading more RAM");

            Console.WriteLine("Your dice are " + diceResult + " and " + diceResult2 + ".");

            Console.WriteLine("The sum is: " + diceSum + ".");
        }
        public static void Task4()
        {
            string answer;
            int randomNumber;

            Random generator = new Random();
            randomNumber = generator.Next(1, 21);

            // the variable is just bogus!! HA HA HA they don't know.

            Console.WriteLine("MAGIC 8 BALL!");
            Console.WriteLine("Ask a question, and I will come up with an answer...");
            answer = Console.ReadLine();
            Console.WriteLine();

            if(randomNumber == 1)
            {
                Loader("Computing");
                Console.WriteLine("It is certain.");
            }

            else if (randomNumber == 2)
            {
                Loader("Computing");
                Console.WriteLine("It is decidedly so.");
            }

            else if (randomNumber == 3)
            {
                Loader("Computing");
                Console.WriteLine("It is decidedly so.");
            }

            else if (randomNumber == 4)
            {
                Loader("Computing");
                Console.WriteLine("Without a doubt.");
            }

            else if (randomNumber == 5)
            {
                Loader("Computing");
                Console.WriteLine("Yes, definitely.");
            }

            else if (randomNumber == 6)
            {
                Loader("Computing");
                Console.WriteLine("You may rely on it.");
            }

            else if (randomNumber == 7)
            {
                Loader("Computing");
                Console.WriteLine("As I see it, yes.");
            }

            else if (randomNumber == 8)
            {
                Loader("Computing");
                Console.WriteLine("Most likely.");
            }

            else if (randomNumber == 9)
            {
                Loader("Computing");
                Console.WriteLine("Outlook good.");
            }

            else if (randomNumber == 10)
            {
                Loader("Computing");
                Console.WriteLine("Yes.");
            }

            else if (randomNumber == 11)
            {
                Loader("Computing");
                Console.WriteLine("Signs point to yes.");
            }

            else if (randomNumber == 12)
            {
                Loader("Computing");
                Console.WriteLine("Reply hazy, try again.");
            }

            else if (randomNumber == 13)
            {
                Loader("Computing");
                Console.WriteLine("Ask again later.");
            }

            else if (randomNumber == 14)
            {
                Loader("Computing");
                Console.WriteLine("Better not tell you now.");
            }

            else if (randomNumber == 15)
            {
                Loader("Computing");
                Console.WriteLine("Cannot predict now.");
            }

            else if (randomNumber == 16)
            {
                Loader("Computing");
                Console.WriteLine("Concentrate and ask again.");
            }

            else if (randomNumber == 17)
            {
                Loader("Computing");
                Console.WriteLine("Don’t count on it.");
            }

            else if (randomNumber == 18)
            {
                Loader("Computing");
                Console.WriteLine("My reply is no.");
            }

            else if (randomNumber == 19)
            {
                Loader("Computing");
                Console.WriteLine("My sources say no.");
            }

            else if (randomNumber == 20)
            {
                Loader("Computing");
                Console.WriteLine("Outlook not so good.");
            }
        }
    }
}
