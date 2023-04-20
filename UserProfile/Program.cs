using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your age");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1}", name, age);

        Console.WriteLine("Enter your birthdate: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Your birthdate is {0}", birthdate);

        Console.ReadKey();
    }
}