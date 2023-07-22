using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class SumOfDigits
    {
        public void FindSumOfDigits()
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
