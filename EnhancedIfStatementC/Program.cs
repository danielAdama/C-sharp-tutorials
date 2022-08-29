namespace EnhancedIfStatement
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Condition ? first_expression : second_expression;
            // Condition has to be either True or False
            // The conditional operator is right - associative.
            // The expression a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)

            int temp = -5; string stateofMatter;

            
            if (temp < 0)
            {
                stateofMatter = "solid";
            }
            else if (temp > 100)
            {
                stateofMatter = "gas";
            }
            else
            {
                stateofMatter = "Liquid";
            }
            Console.WriteLine("If Statement - State of Matter {0}", stateofMatter);
            temp += 30;
            

            stateofMatter = temp < 0 ? "solid" : "Liquid";
            Console.WriteLine("Short If Statement - State of Matter {0}", stateofMatter);

            temp += 100;
            stateofMatter = temp > 100 ? "gas" : (temp < 0 ? "solid": "Liquid");
            Console.WriteLine("Short If Statement - State of Matter {0}", stateofMatter);
            
        }
    }
}