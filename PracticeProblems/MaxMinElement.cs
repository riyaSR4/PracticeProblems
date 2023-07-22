using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeProblems
{
    public class MaxMinElement
    {
        public void  FindMaxMinElement()
        {
            Console.WriteLine("Enter the limit of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = ar[0];
            int min = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > max)
                    max = ar[i];
                if (ar[i] < min)
                    min = ar[i];
            }
            Console.WriteLine("Maximum Element: " + max);
            Console.WriteLine("Minimum Element: " + min);
        }
    }
}
