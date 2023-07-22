using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Count No.of duplicate elements in an array\n " +
                    "2.Print all unique elements in an array\n 3.Count the frequency of each element of an array\n " +
                    "4.Find maximum and minimum element in an array\n 5.Print pattern\n 6.Print second pattern\n " +
                    "7.Reverse each word in a string\n 8.Exit\n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        DuplicateElements duplicateElements = new DuplicateElements();
                        duplicateElements.CountDuplicatesElements();
                        break;
                    case 2:
                        UniqueElements uniqueElements = new UniqueElements();
                        uniqueElements.PrintUniqueElements();
                        break;
                    case 3:
                        Frequency frequency = new Frequency();
                        frequency.CountFrequency();
                        break;
                    case 4:
                        MaxMinElement maxMinElement = new MaxMinElement();
                        maxMinElement.FindMaxMinElement();
                        break;
                    case 5:
                        PrintPattern printPattern = new PrintPattern();
                        printPattern.PrintGivenPattern();
                        break;
                    case 6:
                        PrintPattern2 printPattern2 = new PrintPattern2();
                        printPattern2.PrintGivenPattern2();
                        break;
                    case 7:
                        ReverseEachWord reverseEachWord = new ReverseEachWord();
                        reverseEachWord.PrintReverseEachWord();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}