using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP
{
    class Human
    {
        // Create members in the Humans class
        // // Attributes of class Human
        // public string first_name;
        // public string last_name;

        private string first_name;
        private string last_name;
        private string eye_color;
        private int age;

        // Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }


        // // Parameterized Constructors
        // public Human(string firstName, string last_name, string eye_color, int age)
        // {
        //     first_name = firstName;
        //     this.last_name = last_name; // this it used to get a value from a previous variable.
        //     this.eye_color = eye_color;
        //     this.age = age;

        // }

        public Human(string firstName, string last_name, string eye_color, int age)
        {
            first_name = firstName;
            this.last_name = last_name; // this it used to get a value from a previous variable.
            this.eye_color = eye_color;
            this.age = age;

        }

        public Human(string firstName, string last_name)
        {
            this.first_name = first_name;

        }
        
        public Human(string firstName, string last_name)
        {
            first_name = firstName;
            this.last_name = last_name;

        }

        public Human(string eye_color, int age)
        {
            this.eye_color = eye_color;
            this.age = age;

        }

        // A Method/Function of class Human
        public void introduceMyself()
        {
            if (age != 0 && last_name != null && eye_color != null && first_name != null)
            {
                Console.WriteLine($"Hi, I am {first_name} {last_name} with {eye_color} eyes of age {age}");
            }
            else if (age != 0 && last_name != null && first_name != null)
            {
                Console.WriteLine($"Hi, I am {first_name} {last_name} of age {age}");
            }
            else if (last_name != null && first_name != null)
            {
                Console.WriteLine($"Hi, I am {first_name} {last_name}");
            }
            else if (first_name != null)
            {
                Console.WriteLine($"Hi, I am {first_name}");
            }
            else
            {
                Console.WriteLine($"Finished");
            }
            
        }


    }
}