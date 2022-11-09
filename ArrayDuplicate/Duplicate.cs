using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDuplicate
{
    internal class Duplicate
    {
        public void DuplicateItem()
        {
            int n, i;
            int[] arr = new int[15];

            Console.WriteLine("No of elements to be in the array:");
            n = Int32.Parse(Console.ReadLine());


            //Searches for duplicate element  
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("enter the array elements");
                arr[i] = Int32.Parse(Console.ReadLine());
            }


            Console.Write("\nThe values store into the array are :");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }


            Console.WriteLine("\n Duplicate elements in given array:\n ");
            for (i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }
        }
    }
}


