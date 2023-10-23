using System.Diagnostics.SymbolStore;

namespace higherLowerHeadsTails
{
    class Program
    {

        static void Main(string[] args)
        {
            headTail();
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
                if (int.TryParse(temp1, out guess) && (Convert.ToInt32(temp1) <= 50) && (Convert.ToInt32(temp1) >= 1))
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
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            bool keepGoing = true;

            Console.WriteLine("Heads or Tails? Press 0 to quit.\n 1. Heads\n 2. Tails");
            while (keepGoing) {
                string temp1 = Console.ReadLine();
                int guess;
           
            
                if (int.TryParse(temp1, out guess) && (Convert.ToInt32(temp1) <= 2) && (Convert.ToInt32(temp1) >= 1))
                {
                    guess = Convert.ToInt32(temp1);
                    if (guess == value)
                    {
                        keepGoing = false;
                        Console.WriteLine("You got it!");
                    }
                    else if(guess != value)
                    {
                        keepGoing= false;
                        Console.WriteLine("That's Wrong!");
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
    }
}