using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// NOTE: Properties always starts with capital letters
namespace properties
{
    class Box
    {
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                // height = value;
                if (value < 0)
                {
                    height = -value; //If the value given is negative, multiply it by (-*number) to convert to positive
                }
                else
                {
                    height = value;
                }
            }
        }


        public void SetLength(int length)
        // Method to change a private variable
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;

        }

        public int GetLength()
        // Method to get a private variable
        {
            return this.length;
        }

        // This is a method
        public void displayInfo()
        {
            Console.WriteLine($"Length is {length}, height is {height} and width is {width} so the volume is {volume=length*height*width}");
        }

    }
}