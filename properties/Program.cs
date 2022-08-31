using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box boxdetails = new Box();
            boxdetails.SetLength(4);
            // boxdetails.height = 4;
            boxdetails.Height = -4;
            boxdetails.width = 5;

            Console.WriteLine($"Box lenght is {boxdetails.GetLength()}");
            boxdetails.displayInfo();


        }
    }
}