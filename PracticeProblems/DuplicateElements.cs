using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class DuplicateElements
    {
        public void CountDuplicatesElements()
        {
            Console.WriteLine("Enter the limit of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            var dict = new Dictionary<int, int>();
            foreach (var value in ar)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                { 
                    dict[value] = 1;
                }
            }
            int count = 0;
            foreach (var data in dict)
            {
                if (data.Value > 1)
                    count += data.Value;
            }
                    Console.WriteLine("Total number of duplicate elements: " + count);
        }

    }
}
