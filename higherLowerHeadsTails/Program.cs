using System.Diagnostics.SymbolStore;

namespace higherLowerHeadsTails
{
    class Program
    {

        static void Main(string[] args)
        {
            lowHigh();
        }



        public static void lowHigh()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 50);
            bool keepGoing = true;

            Console.WriteLine($"Guess a number between 1 and 50 {value}, press 0 to quit");
            
            while (keepGoing)
            {
                string temp1 = Console.ReadLine();
                int guess;
                if (int.TryParse(temp1, out guess))
                {
                    guess = Convert.ToInt32(temp1);

                    if (guess == value)
                    {
                        keepGoing = false;
                        Console.WriteLine("You got it!");
                    }
                    else if (guess > value)
                    {
                        Console.WriteLine("That's too high!");
                    }
                    else if (guess < value)
                    {
                        Console.WriteLine("That's too low!");
                    }
                    else if (guess == 0)
                    {
                        keepGoing = false;
                        Console.WriteLine("Thanks for playing!");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid Answer");
                }
            }
        }

        public static void headTail()
        {

        }
    }
}