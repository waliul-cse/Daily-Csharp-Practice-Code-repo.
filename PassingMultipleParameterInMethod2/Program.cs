using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingMultipleParameterInMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1, x2 = 4, x3 = 5, x4 = 10;
            long n = 110;

            int result = Summation(n, x2, x3, x4);
            Console.WriteLine(result);

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int result=Summation(arr);
            //Console.WriteLine(result);
            Console.ReadLine();
        }

        //we can pass multiple parameter in a method using params arguments
        //Note: params parameter must be the last parameter of formal parameter list
        static int Summation(long n, params int[] args)
        {

            int sum = 0;
            foreach (var num in args)
            {
                sum += num;

            }
            return sum;

        }
    }
}
