using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class NewExtension
    {
        //Extension method must be static and need to use "this" before first parameter
        public static int Add(this int a, int b)
        {
            return a + b;


        }

        //Overloading method example
        public static int Add(this int a, int b, int c)
        {
            return a + b + c;


        }

        public static int Hello(this int source)
        {

            return source / 2;
        }

        public static int Double(this int source)
        {

            return source * 2;
        }

        public static int Square(this int source)
        {

            return source * source;
        }
    }
}
