using System;

namespace CSharpVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LocalVariable.StudentAge();
            LocalVariables1.StudentAge();
            InstanceVariables obj1= new InstanceVariables();
            obj1.EngMarks = 75;
            obj1.MarMarks = 90;
            obj1.HindiMarks = 80;
            obj1.StudentMarks();

            InstanceVariables obj2 = new InstanceVariables();
            obj2.EngMarks = 80;
            obj2.MarMarks = 94;
            obj2.HindiMarks = 80;
            obj2.StudentMarks();
            Console.ReadLine();
        }
    }
}
