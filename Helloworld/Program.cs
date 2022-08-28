// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World!");
//     }
// }

using System;

namespace Helloworld
{
    public class MyFirstApp
{
    public static void Main(string[] args)
    {
        string username = "Daniel";
        int number = 2;
        float price = 3.99f;
        

        Console.WriteLine("Hello "+username);
        Console.WriteLine("The total price is: "+(number*price));

    }
}
}