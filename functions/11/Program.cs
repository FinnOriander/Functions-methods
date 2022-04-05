using System;

namespace _11
{
     class Program
 {
   static void Main()
    {
      decimal E;

	  Console.Write("Input a number : ");
      int num= Convert.ToInt32(Console.ReadLine());
      E = Factorial(num);
      Console.WriteLine("The factorial of {0} is  {1}!", num, E);
    }
   static decimal Factorial(int n1)
    {

      if (n1 == 0)
        {
         return 1;
        }

       else
        {
          return n1 * Factorial(n1 - 1);
        }
    }
 }
}
