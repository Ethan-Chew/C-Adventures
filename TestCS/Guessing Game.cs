using System;
namespace TestCS
{
    public class Guessing_Game
    {
        public Guessing_Game()
        {
            // Get Min, Max and Correct Answer
            int[] minMax = new int[2];
            while (true)
            {
                try
                {
                    Console.Write("Enter the Minimum Number: ");
                    minMax[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Maximum Number: ");
                    minMax[1] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid Numbers!");
                }
            }
            int correctAnswer = createRandom(minMax[0], minMax[1]);

            // Does User Want Clues?
            bool cluesEnabled = false;
            Console.Write("Clues Enabled (Type Yes or No): ");
            string reply = Console.ReadLine();
            if (reply.ToLower() == "yes")
            {
                cluesEnabled = true;
            }

            // Actual Game
            int userTries = 1;
            while (true)
            {
                Console.Write("Your Guess: ");
                try
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (cluesEnabled)
                    {
                        if (guess > correctAnswer)
                        {
                            Console.WriteLine("Your Guess is Higher than the Correct Answer! Try Again!");
                            userTries += 1;
                        }
                        else if (guess < correctAnswer)
                        {
                            Console.WriteLine("Your Guess is Lower than the Correct Answer! Try Again!");
                            userTries += 1;
                        }
                        else
                        {
                            string word = (userTries == 1 ? " Try!" : " Tries!");
                            Console.WriteLine("Good Job! You got it in " + userTries + word);
                            break;
                        }
                    }
                    else
                    {
                        if (guess != correctAnswer)
                        {
                            Console.WriteLine("Nope! Try Again!");
                        }
                        else
                        {
                            string word = (userTries == 1 ? " Try!" : " Tries!");
                            Console.WriteLine("Good Job! You got it in " + userTries + word);
                            break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Guess (Not an Integer)!");
                }
            }
        }

        static int createRandom(int min, int max)
        {
            Random Random = new Random();
            return Random.Next(min, max);
        }
    }
}
