using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] arr = new int[100000];

            stopWatch sw = new stopWatch();
            sw.Start();
            for (int i  = 0; i < arr.Length; i++)
            {
                arr[i] = (int)rd.Next(500);
            }
            for(int i  = 0; i < arr.Length - 1; i++)
            {
                int currentMin = arr[i];
                int minIndex = i;
                for(int j = i+1; j< arr.Length; j++)
                {
                    if(currentMin > arr[j])
                    {
                        currentMin = arr[j];
                        minIndex = j;
                    }
                    
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            sw.Stop();
            for (int a = 0 ; a < arr.Length; a++)
            {
                Console.WriteLine(arr[a]);
            }
            Console.WriteLine("Thoi gian chay: " + sw.GetTime());
            Console.ReadKey();
        }
    }
}
