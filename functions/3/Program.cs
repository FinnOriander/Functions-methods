using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {  
            int n1,n2;
            int sum;

            Console.WriteLine("Enter a number:");
            n1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            n2= Convert.ToInt32(Console.ReadLine());

            sum = add(n1,n2);

            Console.WriteLine("The Sum of two numbers is:" +sum);
        }

        static int add(int n1, int n2)
        {
            return (n1+n2);
        }
    }
}
