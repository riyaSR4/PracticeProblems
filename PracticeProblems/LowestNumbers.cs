using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class LowestNumbers
    {
        public void LowestNumbersAndSum()
        {
            Console.WriteLine("Enter the limit of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] lowest = new int[2];
            Array.Sort(ar);
            lowest[0] = ar[0];
            lowest[1] = ar[1];
            Console.WriteLine("The two lowest numbers in the array is: " + ar[0] + " & " + ar[1]);
            int sum = 0;
            foreach(int num in ar)
            {
                if (num >= 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Sum of the two lowest positive numbers is:" + sum);
        }
    }
}
