using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //output execution
            // Console.WriteLine("Welcome to C#");
            //Console.ReadKey();
            
            //Declaring datatype of variable: datatype var_name;
            //string firstName;
            //string lastName;
            //Console.WriteLine("Enter 1st Name:");
            //Console.WriteLine("Enter Last Name");
            //firstName = Console.ReadLine();
            //lastName = Console.ReadLine();  
           // Console.WriteLine("Welcome Mr.\\Ms. "+firstName+" "+lastName);
            //Console.ReadKey(); //staying on the console

            //ex-03 Datatype.Parse()
            string name;
            char grade;
            int age;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name: ");
            name=Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());// error as it reads only string
            Console.WriteLine("Enter Grade: ");
            grade=char.Parse(Console.ReadLine());   
            Console.WriteLine("Enter Date of Joining: ");
            doj=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Name: \t" + name + "\n Age: " + age + "\n Grade: \t" + grade +
                "\n Salary: \t" + salary + "\nDate of Joining: \t" + doj);
            Console.ReadLine();


        }
    }
}
