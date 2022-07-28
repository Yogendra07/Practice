using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program2
    {
        //public delegate void MyDelegate(string msg); //declaring a delegate

        static int Sum(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            /* MyDelegate del1 = ClassA.MethodA;
             MyDelegate del2 = ClassB.MethodB;

             MyDelegate del = del1 + del2;
             del("Hello World");*/

            Func<int, int, int> add = Sum;

            int result = add(10, 20);

            Console.WriteLine(result);

            Console.WriteLine(result);  

        }

        /*public class ClassA
        {
            public static void MethodA(string message)
            {
                Console.WriteLine("Called ClassA.Method() with Paremeter : " + message);
            }
        }

        public class ClassB
        {
            public static void MethodB(string message)
            {
                Console.WriteLine("Called ClassB.Method() with Paremeter : " + message);
            }
        }*/
    }
}
