using System;
using System.Collections.Generic;

namespace Epam.Task3._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double frequency;
            Dictionary<string, int> wordFrequences = new Dictionary<string, int>();

            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            string[] words = text.ToLower().Split(' ', '.');
            
            for (int i = 0; i < words.Length; i++)
            {
                if (!wordFrequences.ContainsKey(words[i]))
                {
                    wordFrequences.Add(words[i], 1);
                }
                else
                {
                    wordFrequences[words[i]]++;
                }
            }

            foreach (var w in wordFrequences)
            {
                frequency = ((double)w.Value / words.Length) * 100;
                Console.WriteLine($"{w.Key} - {Math.Round(frequency, 2)}%");
            }
        }
    }
}
