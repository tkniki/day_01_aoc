using System;
using System.IO;

namespace day_01
{
    class Program
    {
        static Boolean DoesItIncrease (int[] arr, int index)
        {
            /*if (index != 0 && arr[index] > arr[index-1])
            {
               return true;
            }
            return false;*/
            //shorter solution:
            return (index != 0 && arr[index] > arr[index-1]);
        }

        static int CountIncreased (int[] arr)
        {
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (DoesItIncrease(arr, i))
                {
                    num++;
                }
            }
            return num;
        }

        

        static void Main(string[] args)
        {
            int[] measurements = new int[2000];
            StreamReader sr = new StreamReader("C:\\Users\\trank\\Documents\\Advent of Code 2021\\01_input.txt");
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] = Convert.ToInt32(sr.ReadLine());
                /*Console.WriteLine(measurements[i]);*/
            }



            Console.WriteLine(CountIncreased(measurements));
        }
    }
}
