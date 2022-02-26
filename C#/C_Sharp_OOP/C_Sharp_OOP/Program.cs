using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_OOP
{
    internal class Program
    {
        string color;
        public string language;

        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }


        public Program(string language){
            //language = "Java";
            this.language = language;

        }
        public Program()
        {
            language = "C";
        }

        private string firstname; 

        public string Name  
        {
            get { return firstname; }   
            set { firstname = value; }  
        }

        static void Main(string[] args)
        {
            Program myObj = new Program();
            myObj.color = "yellow";
            Console.WriteLine(myObj.color);
            myObj.fullThrottle(); 
            Console.WriteLine(myObj.language);

            Program myObj2 = new Program("C#");
            Console.WriteLine(myObj2.language);
         

            myObj.Name = "Hinal";
            Console.WriteLine(myObj.Name);

            Console.ReadLine();

        }
    }
}
