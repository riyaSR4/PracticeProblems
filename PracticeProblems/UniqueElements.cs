using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class UniqueElements
    {
        public void PrintUniqueElements()
        {
            Console.WriteLine("Enter the limit of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            HashSet<int> uniqueElements = new HashSet<int>();
            foreach (int element in ar)
            {
                if (!uniqueElements.Contains(element))
                {
                    uniqueElements.Add(element);
                }
            }
            Console.WriteLine("Unique elements in the array:");
            foreach (int element in uniqueElements)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
}
