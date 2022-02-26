using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.Write("Hello Hinal");
            //Console.WriteLine("I Love C#");

            // int num1 = 22;
            /* Date type :
             int,float,char,bool,string*/

            /*Console.WriteLine("Number is " + num1);
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();
            Console.WriteLine("Entered String is : "+str); */

            /*int num = 10;
            float f = 34.7F;
            double d = 34.4D;
            bool b = true;
            string s = "Hinal";
            char c = 'H';
            Console.WriteLine(num);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(s); */


            //Type Casting
            /* int i = (int)2.3;
             Console.WriteLine(i);*/

            /* Console.WriteLine("Enter username:");

             string userName = Console.ReadLine();
             Console.WriteLine("Username is: " + userName);*/


            //Operator
            int x = 3;
            x += 3;
            Console.WriteLine(x);
            Console.WriteLine(Math.Round(5.9));
            Console.WriteLine(Math.Max(6,9));
            Console.WriteLine(Math.Min(6,9));
            Console.WriteLine(Math.Sqrt(82));


            string str1 = "C# is Very Easy.";
            Console.WriteLine("The length of the String is : " + str1.Length);
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());


            string firstName = "Hinal ";
            string lastName = "Hapani";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string fullName = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(fullName);

            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString.IndexOf("e"));







            Console.ReadLine();
        }
    }
}
