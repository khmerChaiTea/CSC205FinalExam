using System;
using System.Linq;

namespace CSC205FinalExam
{
    public class Program
    {
        public static void Main()
        {
            // Test cases
            Console.WriteLine(IsDoubloon("April"));
            Console.WriteLine(IsDoubloon("MadamD"));
            Console.WriteLine(IsDoubloon("Cherry"));
            Console.WriteLine(IsDoubloon("Shanghaiings"));
            Console.WriteLine(IsDoubloon("giggling"));
            Console.WriteLine(IsDoubloon("IbeIbe"));
            Console.WriteLine(IsDoubloon("Sleeping"));
        }

        public static bool IsDoubloon(string word)
        {
            // Convert the word to lowercase to handle case-insensitivity
            word = word.ToLower();

            // Group the characters in the word and check if each character appears exactly twice
            foreach (char c in word)
            {
                if (word.Count(ch => ch == c) != 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}