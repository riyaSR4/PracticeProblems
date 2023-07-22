using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class ReverseEachWord
    {
        public void PrintReverseEachWord()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            string reversedString = string.Join(" ", words);
            Console.WriteLine("Reversed sentence:");
            Console.WriteLine(reversedString);
        }
    }
}
