using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MembersC
{
    class Members
    {
        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;

        // This is a member property which exposes jobTitle safely
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}, and my job title is {jobTitle}. I am {age} years old");
            }

        }

        private void sharingPrivateInfo()
        {
            Console.WriteLine($"My Salary is {salary}");
        }

        public Members()
        {
            age = 30;
            memberName = "Daniel";
            salary = 60000;
            jobTitle = "Machine Learning Engineer";
            Console.WriteLine("Object created");
        }

        // member - finalizer or destructor
        ~Members()
        {
            // Clean up statements
            Console.WriteLine("Deconstruction of Members");
            Debug.Write("Deconstruction of Members object");
        }
    }
}