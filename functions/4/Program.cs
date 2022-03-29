using System;

namespace _4
{
    class Program
    {	public static int SpaceCount(string str)
	  {   
		 int sstt=0;
		 string str1;
		 for (int i = 0;i < str.Length;i++)
			{
			  str1 = str.Substring(i,1);
			  if (str1 == " ")
					sstt++;
			}
		return sstt;
	  }
        public static void Main()
	  {
	     string str2;
		 Console.Write("Test Data:\n");
		 Console.Write("Please input a string : ");
         str2 = Console.ReadLine();
		 Console.WriteLine("\""+str2+"\""+" contains {0} spaces", SpaceCount(str2) );
	  }  
    }    
}

