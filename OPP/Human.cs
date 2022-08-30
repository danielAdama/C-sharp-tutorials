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

        // Constructors
        public Human(string firstName, string last_name, string eye_color, int age)
        {
            first_name = firstName;
            this.last_name = last_name; // this it used to get a value from a previous variable.
            this.eye_color = eye_color;
            this.age = age;

        }

        // A Method/Function of class Human
        public void introduceMyself()
        {
            Console.WriteLine($"Hi, I am {first_name} {last_name} with {eye_color} eyes of age {age}");
        }


    }
}