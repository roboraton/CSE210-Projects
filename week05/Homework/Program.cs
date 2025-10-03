using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Note from teacher -> // Create a base "Assignment" object

        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSumary());

        //Note from teacher -> // Now create the derived class assignments

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomeworkList());

        WrittinAssignment a3 = new WrittinAssignment("Mary Waters", "European History", "The causes of World War II");
        Console.WriteLine(a3.GetSumary());
        Console.WriteLine(a3.GetWrittingInformation());
    }
}