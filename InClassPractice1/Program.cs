// Aaron Petersen   Mission #2
using System;

namespace InClassPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dice = new int[11];

            Console.Write("Welcome to the dice throwing simulator!");

            // Recieving input from user for the number of rolls
            Console.Write("How many dice rolls would you like to simulate? ");
            int numTimes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \nEach '*' represents 1 % of the total number of rolls.\nTotal number of rolls = " + numTimes);

            Random r = new Random();

            // Simulate the roll of one die for users input number of times
            for (int i = 0; i < numTimes; i++)  //This is how for loops work.  
            {
                int roll = r.Next(6) + r.Next(6);  // the ones are in the 0 postion, twos in the 1 position

                dice[roll] = dice[roll] + 1;    
            }

            // Prints * for each 1% of the number of rolls
            for (int i = 0; i < 11; i++)
            {
                
                float x = dice[i] * 100 / numTimes;

                string result = "";

                for (int p = 0; p < x; p++)
                {
                    result += "*";
                }

                Console.WriteLine(i+2 + ": " + result);
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            
        }
    }
}
