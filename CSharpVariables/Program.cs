using System;

namespace CSharpVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
         

            StaticVariables.salary = 24500;
            Console.WriteLine("Employee name is " +StaticVariables.name + " and his minimum salary is " + StaticVariables.salary);
            Console.ReadLine();
        }
    }
}
