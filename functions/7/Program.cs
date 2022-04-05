using System;

namespace _7
{
    class Program
 {
   public static void Main()
   {
      int n1;
      int exp1;
	  Console.Write("Input Base number: ");
      n1= Convert.ToInt32(Console.ReadLine());
      Console.Write("Input the Exponent : ");
      exp1= Convert.ToInt32(Console.ReadLine());	  
      Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ",n1, exp1, PowerRaising(n1, exp1));
    }
     public static int PowerRaising(int num, int exp)
   {
     int rvalue = 1;
     int i;
     for (i=1;i<=exp;i++)
     rvalue=rvalue*num;
     return rvalue;
   }

}  

}
