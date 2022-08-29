namespace MyFirstApp // project name
{
    public class MyFirstApp
    {
        // Explicitly Datatypes - Are outside the function
        static float price = 3.99f;
        // string name = "Daniel";
        // char letter = 'a';
        // int number = 1000000;
        // bool toggle = true;


        public static void Main(string[] args) // <- Method/Function
        {
            // Implicitly Datatype - Are inside the function which automatically detects the datatype
            // var username = true; // bool
            Console.WriteLine("price"+price);
            WriteSomething("Called from with in a function");
            Console.WriteLine(Add(1, 31));
            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Divide(25, 13));

            // How to collect user input
            // int output = 2 + 2;
            Console.WriteLine(Calculate());

            // Try Except block
            Console.WriteLine("Please enter a number!");
            string inpasstr = Console.ReadLine();
            try
            {
                int inpasIn = int.Parse(inpasstr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please check your string format");

            }
            // int inpasint = Convert.ToInt32(Console.ReadLine());

            string first_name = "Daniel";
            string second_name = "Adama";
            string country = "Nigeria";
            Console.WriteLine($"My name is {first_name} {second_name} from {country}");


        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            return result;
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
