using System;

namespace Epam.Task1._12
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string mainString = Console.ReadLine();
            Console.WriteLine("Enter the substring: ");
            string substring = Console.ReadLine();

            int found = 0;
            char[] charSubstring = substring.ToCharArray();
            char[] charMainString = mainString.ToCharArray();
            foreach (char ss in charSubstring) {
                found = mainString.IndexOf(ss);
                mainString.Replace(mainString.Substring(found), $"{ss}{ss}");
            }
            Console.WriteLine(mainString);
        }
    }
}
