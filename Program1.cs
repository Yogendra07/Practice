using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program1
    {
        static void Main(string[] args)
        {
            /*Task<int> result = LongProcess();
            ShortProcess();

            var val = await result;

            Console.WriteLine("Result : {0}",val);

            Console.ReadKey();*/

            Console.Write("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter a day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime inputtedDate = new DateTime(year, month, day);

            DateTime today = DateTime.Now;
            
            if(month <= today.Month)
            {
                int a =  today.Year - year;
                Console.WriteLine("His age is : {0} years ",a);
            }
            else
            {
                int a = today.Year - year - 1;
                Console.WriteLine("His age is : {0} years  ", a);
            }




        }

       /* static async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started");
            await Task.Delay(4000);
            Console.WriteLine("LongProcess Completed");
            return 10;
        }

        static void ShortProcess()
        {
            Console.WriteLine("Short Process Started");
            Console.WriteLine("ShortProcess Completed");
        }*/
    }
}
