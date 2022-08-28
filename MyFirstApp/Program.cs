namespace MyFirstApp // project name
{
    public class MyFirstApp
    {
        // Explicitly Datatypes - Are outside the function
        // float price = 3.99f;
        // string name = "Daniel";
        // char letter = 'a';
        // int number = 1000000;
        // bool toggle = true;


        public static void Main(string[] args) // <- Method/Function
        {
            // Implicitly Datatype - Are inside the function which automatically detects the datatype
            // var username = true; // bool
            // Console.WriteLine("vat"+vat);
            // WriteSomething("Called from with in a function");
            // Console.WriteLine(Add(1, 31));
            // Console.WriteLine(Multiply(2, 2));
            // Console.WriteLine(Divide(25, 13));

            // How to collect user input
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }

        public static void WriteSomething(string text)
        {
            Console.WriteLine(text);
        }
        
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
           
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
