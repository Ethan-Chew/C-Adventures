using System;
namespace TestCS
{
    public class BasicCalculator
    {
        public BasicCalculator()
        {
            // Variables
            string[] splittedEqn = new string[3];
            int[] values = new int[2];

            // Main Code
            while (true)
            {
                Console.Write("Enter a Simple Equation: ");
                string eqn = Console.ReadLine();

                splittedEqn = eqn.Split(" ");

                try
                {
                    values[0] = Convert.ToInt32(splittedEqn[0]);
                    values[1] = Convert.ToInt32(splittedEqn[2]);
                    break;
                }
                catch
                {
                    Console.WriteLine("Error, Invalid Numbers");
                }
            }


            switch (splittedEqn[1])
            {
                case "+":
                    Console.WriteLine(values[0] + values[1]);
                    break;
                case "-":
                    Console.WriteLine(values[0] - values[1]);
                    break;
                case "*":
                    Console.WriteLine(values[0] * values[1]);
                    break;
                case "/":
                    Console.WriteLine(values[0] / values[1]);
                    break;
                case "%":
                    Console.WriteLine(values[0] % values[1]);
                    break;
                default:
                    Console.WriteLine("Bruh, Invalid Operator, " + splittedEqn[1], "!");
                    break;
            }
        }
    }
}
