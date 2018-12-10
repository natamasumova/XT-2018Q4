using System;
using System.Collections.Generic;

namespace Epam.Task3._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of players: ");
            int players = int.Parse(Console.ReadLine());
            List<string> round = new List<string>(players);

            ShowProcess(players, round);
            Console.ReadKey();
        }

        public static void ShowProcess(int players, List<string> round)
        {
            int counter = 0;
            int i = 1;
            while (i <= players)
            {
                round.Add(i.ToString());
                i++;
            }

            foreach (var item in round)
            {
                Console.Write(item);
            }

            while (players != 1)
            {
                for (int j = 0; j < round.Count; j++)
                {
                    if (round[j] != "-")
                    {
                        counter++;
                    }
                    if (counter == 2)
                    {
                        counter = 0;
                        round[j] = "-";
                        players--;
                        foreach (var r in round)
                        {
                            Console.Write(r);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
