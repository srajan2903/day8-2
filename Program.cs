using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size= int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Using Lambda Function
            // Array.Sort(arr, (x,y)=>x.CompareTo(y));
            // Using Anonymous
            Array.Sort(arr, delegate (int x, int y)
            {
                return x.CompareTo(y);
            });
            Console.WriteLine("Sorted array in ascending order");
            foreach(var num in arr)
            {
                Console.WriteLine(num + " ");

            }
            Console.Read();
        }
    }
}
