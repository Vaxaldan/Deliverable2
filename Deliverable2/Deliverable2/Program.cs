namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string coinResult;
                string userInput;
                int game = 0; // total times the game has run
                int score = 0; // total times player won
                Random rng = new Random();

                Console.Write("Welcome to the COIN FLIP CHALLENGE! What is your name? ");
                string name = Console.ReadLine();

                Console.Write("Hello " + name + "! Would you like to try the COIN FLIP CHALLENGE? (Yes or No): ");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "no")
                {
                    Console.WriteLine("You are a Coward " + name + "!");
                }
                else if (answer == "yes")
                {
                    while (game < 5)
                    {
                        Console.Write("Heads or Tails? ");
                        userInput = Console.ReadLine().Trim().ToLower();

                        if (userInput != "heads" && userInput != "tails")
                        {
                            Console.WriteLine("Invalid input! Please enter 'heads' or 'tails'.");
                            continue;
                        }

                        int coin = rng.Next(0, 2);
                        coinResult = (coin == 0) ? "heads" : "tails";

                        if (coinResult == userInput)
                        {
                            Console.WriteLine("You selected " + userInput + " and the coin landed on " + coinResult + "! You get one point!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("You selected " + userInput + " and the coin landed on " + coinResult + "! Try again!");
                        }

                        game++;
                    }

                    Console.WriteLine("Thank you " + name + " for playing! You got " + score + " points! Please play again soon!");
                }
                else
                {
                    Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}
