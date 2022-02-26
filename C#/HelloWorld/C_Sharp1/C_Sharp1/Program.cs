using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1
{
    internal class Program
    {

        static void MyMethod(String fname)
        {
            Console.WriteLine("MyMethod function called");
            Console.WriteLine("My Firstname is " + fname);
        }

        static int addition(int num1,int num2)
        {
            return (num1 + num2);
        }
        static int addition(int num1, int num2, int num3)
        {
            return ( num1 + num2 + num3);
        }


        static void Main(string[] args)
        {
            //Conditional
            /*Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater than num2");
            }*/
            /* int time = 22;
             if (time < 10)
             {
                 Console.WriteLine("Good morning.");
             }
             else if (time < 20)
             {
                 Console.WriteLine("Good day.");
             }
             else
             {
                 Console.WriteLine("Good evening.");
             }*/


            /*int time = 7;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);*/

            /*int day = 6;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }*/

            //while Loop
            /* Fibonacco series
            int num1 = 0;
            int num2 = 1;
            int num3;
            int i = 0;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            while (i<10)
            {
                num3=num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.WriteLine(num3);
                i++;
            } */

            //for loop

            /*int i;
            for (i = 0; i <= 40; i += 2)
            {
                Console.WriteLine(i);
            }*/



            //MyMethod("Hinal");


            /*int add1 = addition(3, 4);
            int add2 = addition(3, 4, 5);

            Console.WriteLine(add1);
            Console.WriteLine(add2);*/

            string[] animals = { "Dog", "Cat", "Cow" };
            Console.WriteLine(animals.Length);
           /* for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            } */
           Array.Sort(animals);
           foreach(string animal in animals)
            {
                Console.WriteLine(animal);
            }

            int[] numbers = { 54,46,78,12,67 };
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Maximum : "+numbers.Max());
            Console.WriteLine("Minimum : " + numbers.Min());

            Console.ReadLine();

        }
    }
}
