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
                    "2.Print all unique elements in an array\n 3.Exit\n");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}