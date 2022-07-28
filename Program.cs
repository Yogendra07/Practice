namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*int numInt = 500;

            Type n = numInt.GetType();

            Console.WriteLine("numInt value : " + numInt);
            Console.WriteLine("numInt Type : " + n);

            double numDouble = numInt;

            Type n1 = numDouble.GetType();

            Console.WriteLine("numDouble value : " + numDouble);
            Console.WriteLine("numDouble Type : " + n1);*/


            /*double numDouble = 1.23;
            int numInt = (int)numDouble;

            Console.WriteLine("Orignal Double Value :" + numDouble);
            Console.WriteLine("Converted int value : "+ numInt);

            string n = "100";

            int a = int.Parse(n);

            Console.WriteLine("Orignal String value : " + n);
            Console.WriteLine("Orignal int value : " + a);
            Console.WriteLine("Type of a is : " + a.GetType());
            Console.WriteLine("Type of n is : " + n.GetType());

            int num = 100;
            Console.WriteLine("int value is : " + num);

            string str = Convert.ToString(num);
            Console.WriteLine("String value is : " + str);

            double val = Convert.ToDouble(num);
            Console.WriteLine("Double value is : " + val);

            int num1 = 0;
            int num2 = 1;

            Boolean bool1 = Convert.ToBoolean(num1);
            Boolean bool2 = Convert.ToBoolean(num2);

            Console.WriteLine("Boolean value of 0 is : " + bool1);
            Console.WriteLine("Boolean value of 1 is : " + bool2);*/

            /* Employee emp;
            emp.id = 1;
            emp.getId(emp.id);*/

            /*Employee emp = new Employee(1,"Brian");
            Console.WriteLine("Employee Name : " + emp.name);
            Console.WriteLine("Employee Id : " + emp.id);*/

            /*  Employee emp1 = new Employee();

              emp1.name = "John";

              //assign emp1 to emp1 

              Employee emp2 = emp1;
              emp2.name = "Ed";
              Console.WriteLine("Employee1 name : " + emp1.name);*/

            string str1 = "C#";
            Console.WriteLine("String str1 : " + str1);

            string str2 = "Programming";
            Console.WriteLine("String str2 : " + str2);

            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("Joined String : " + joinedString);

        }


    }
}