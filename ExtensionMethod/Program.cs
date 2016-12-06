using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x.Add(10);
            Console.WriteLine(y);

            //extension method without parameter
            int hi = 100;
            int result = hi.Hello();
            Console.WriteLine(result);

            //test overload method
            int z = x.Add(100, 50);
            Console.WriteLine(z);

            //More use of extension method
            int s = 100;
            int res = s.Square().Double().Add(5);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
