using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter Element in a array");
            for(int i=0;i<10;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0;  j< arr.Length; j++)
            {
                if(arr[j]%2==0)
                {
                    Console.WriteLine("Even"+arr[j]);
                }
                else
                {
                    Console.WriteLine("Odd"+arr[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
