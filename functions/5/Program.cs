using System;

namespace _5
{
    class Program
    {public static int Add(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                total += arr[i];
            }
            return total;
        }
 
        static void Main(string[] args)
        {
            int sizeArray = 0;
            Console.Write("Input the size of Array : ");
            sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[sizeArray];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0} : ", (i + 1));
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of the elements of the array is:" + Add(numbers));
            Console.ReadKey();
        }
    }
}