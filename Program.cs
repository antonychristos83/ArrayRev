using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element "+(i + 1)+" : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array you've entered ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Method one by printing it backwards");
            for(int i = n-1; i >= 0; i--)
            {
                Console.Write(arr[i]+"\t");
            }
            Array.Reverse(arr);
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Method two by using Array.Reverse()");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            
        }
    }
}
