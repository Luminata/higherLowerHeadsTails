using System.Diagnostics.SymbolStore;

namespace higherLowerHeadsTails
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play 1. HigherLower or 2. HeadsTails? Press 0 to quit.");
            bool keepGoing = true;
            while (keepGoing)
            {
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        lowHigh();
                        break;
                    case "2":
                        headTail();
                        break;
                    case "0":
                        Console.WriteLine("Thanks for playing! :)");
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("That is not a valid choice.");
                        break;

                }
            }
        }



        public static void lowHigh()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 50);
            bool keepGoing = true;

            Console.WriteLine($"Guess a number between 1 and 50, press 0 to quit");
            
            while (keepGoing)
            {
                string temp1 = Console.ReadLine();
                int guess;
                if (int.TryParse(temp1, out guess) && (Convert.ToInt32(temp1) <= 50) && (Convert.ToInt32(temp1) >= 1))
                {
                    guess = Convert.ToInt32(temp1);

                    if (guess == value)
                    {
                        Console.WriteLine("You got it! Press 0 to quit :)");
                        keepGoing=false;
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
                        Console.WriteLine("You got it! Press 0 to quit :)");
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