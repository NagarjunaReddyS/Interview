using System;

namespace Test_Apps
{
    class Program
    {

 //Write   a   program   to   reverse   a   string   “abcdef”   -->   “fedcba”   without   using   the   .NET 
 //reverse()   function  
        static void Main(string[] args)
        {
            FindDivisible();
            StrigReverse();

        }

        public static void FindDivisible()
        {
            for(int i=0; i< 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if(i % 5 == 0 )
                {
                    Console.WriteLine("buzz");
                }
                if (i % 3 == 0 || i % 5 ==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
            }
        }

        public static void StrigReverse()
        {
            string str = "abcdef";
            char[] charValue = str.ToCharArray();
            string rev = string.Empty;
            for(int i = charValue.Length -1; i >=0; i--)
            {
                rev = rev + charValue[i];
            }

            Console.WriteLine(rev);

        }
    }
}
