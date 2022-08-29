namespace OperatorsC
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // Unary Operators - Multiplies a number by 1
            num3 = -num1;
            Console.WriteLine(num3);

            bool isSunny = true;
            Console.WriteLine($"Is it Sunny {!isSunny}");

            Console.WriteLine();
            // Increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}",num);
            // Post-increment operators
            Console.WriteLine("num is {0}",num++);
            Console.WriteLine("num is {0}",num);
            // Pre-increment operators
            Console.WriteLine("num is {0}",++num);

            Console.WriteLine();
            // decrement operator
            num--;
            Console.WriteLine("num is {0}",num);
            // Post-decrement operators
            Console.WriteLine("num is {0}",num--);
            Console.WriteLine("num is {0}",num);
            // Pre-decrement operators
            Console.WriteLine("num is {0}",--num);

            int result;

            result = num1+num2;
            Console.WriteLine("Addtions {0}", result);
            // Note:
            // That modulos returns the remainder when values are divided
            result = num1%num2;
            Console.WriteLine("Modulos {0}", result);

            // Relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("Result of num1 < num2 is {0}", isLower);

            // Equality Operator - == Comparing
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", isEqual);

            // Conditional Operators
            bool isLowerAndSunny;
            // AND
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of isLowerAndSunny is {0}", isLowerAndSunny);

            // OR
            bool isLowerOrSunny;
            isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("Result of isLowerOrSunny is {0}", isLowerOrSunny);
            

        }
    }
}