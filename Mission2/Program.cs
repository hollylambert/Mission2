using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        private static int tempPercent;
        private static float rollPercentage;

        static void Main(string[] args)
        {
            int[] blah = { 45, 20, 67, 10 };
            int count = 0;
            int[] Dice1 = new int[7];
            int[] Dice2 = new int[7];
            string output = "";
            int[] combos = new int[] { };
            string[] ast = new string[] { };

            // Brings in the Random library/class
            Random r = new Random();


            // Set up the rolls array to monitor number of times a number is rolled
            int[] rolls = new int[10];


            for (int i = 0; i < 10; i++)
            {
                rolls[i] = 0;
            }


            // P
            Console.WriteLine("How many dice roll would you like to simulate?");
            int numRolls = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numRolls; i++)
            {
                int v = r.Next(1, 7);
                Dice1 = v;
                int m = r.Next(1, 7);
                Dice2 = m;
                Console.WriteLine(Dice1);
                Console.WriteLine(Dice2);
                rolls[Dice1 - 1]++;
                rolls[Dice2 - 1]++;
                int total = Dice1.Sum() + Dice2.Sum();

                if (total == 2)
                    {
                    combos[0] = combos[0] + 1;
                    ast[0] = ast[0] + '*';
                    count = count++; 
                    }
                if (total == 3)
                {
                    combos[1] = combos[1] + 1;
                    ast[1] = ast[1] + '*';
                    count = count++;
                }
                if (total == 4)
                {
                    combos[2] = combos[2] + 1;
                    ast[2] = ast[2] + '*';
                    count = count++;
                }
                if (total == 5)
                {
                    combos[3] = combos[3] + 1;
                    ast[3] = ast[3] + '*';
                    count = count++;
                }
                if (total == 6)
                {
                    combos[4] = combos[4] + 1;
                    ast[4] = ast[4] + '*';
                    count = count++;
                }
                if (total == 7)
                {
                    combos[5] = combos[5] + 1;
                    ast[5] = ast[5] + '*';
                    count = count++;
                }
                if (total == 8)
                {
                    combos[6] = combos[6] + 1;
                    ast[6] = ast[6] + '*';
                    count = count++;
                }
                if (total == 9)
                {
                    combos[7] = combos[7] + 1;
                    ast[7] = ast[7] + '*';
                    count = count++;
                }
                if (total == 10)
                {
                    combos[8] = combos[8] + 1;
                    ast[8] = ast[8] + '*';
                    count = count++;
                }
                if (total == 11)
                {
                    combos[9] = combos[9] + 1;
                    ast[9] = ast[9] + '*';
                    count = count++;
                }
                if (total == 12)
                {
                    combos[10] = combos[10] + 1;
                    ast[10] = ast[10] + '*';
                    count = count++;
                }
            }
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \n " +
                         "Each '*' represents 1 % of the total number of rolls. \n" +
                         "Total number of rolls: ");
            for (int i = 2; i < 13; i++)
            {
                tempPercent = combos[i - 2] * 100;
                tempPercent = tempPercent / numRolls;
                rollPercentage[i - 2] = tempPercent;

                for (int j = 0; j
                    < rollPercentage[i - 2]; j++)
                {
                    output = output + "*";
                }
                Console.WriteLine(i + ": " + output);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(string.Concat(i + 1, " - ", rolls[i]));
            }


        }
    }
}
