using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program3
    {

         public static void CallToChildThread()
         {
            Console.WriteLine("Child Thread Starts");   
         }
         static void Main()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main : Creating the child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();

        }
    }
}
