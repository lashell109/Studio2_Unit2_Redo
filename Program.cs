using System;
using System.Globalization;

namespace Studio2_Unit2.CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string poem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
            //    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            //    "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
            //    "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in " +
            //    "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            //    "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia " +
            //    "deserunt mollit anim id est laborum.";
            string poem;
            Console.WriteLine("Please enter a string:");
            //poem = Console.ReadLine();
            poem = Console.ReadLine().ToLower();
            Console.WriteLine("Here is your character count:");
            while (poem.Length > 0)

            {
                Console.Write(poem[0] + "=");
                int letters = 0;
                for (int j = 0; j < poem.Length; j++)
                {
                    if (poem[0] == poem[j])
                    {
                        letters++;
                    }
                }
                Console.WriteLine(letters);
                poem = poem.Replace(poem[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}

