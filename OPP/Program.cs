using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human myname = new Human();
            // You can't access a varible from a class when the it doesn't have a public in front
            // of the variable in that class.

            // // This is a way to access public variable from outside.
            // myname.first_name = "Daniel";
            // myname.last_name = "Adama";
            // // This is how to call object of the method Daniel.
            // myname.introduceMyself();

            // Human myname = new Human("Daniel", "Adama", "blue", 24);
            Human natalie = new Human("Natalie");
            natalie.introduceMyself();
            Human mikel = new Human("Mikel", "Jones");
            mikel.introduceMyself();
            Human frank = new Human("Frank", "Walter", 25);
            frank.introduceMyself();





            myname.introduceMyself();
            Human simon = new Human();
            simon.introduceMyself();




            
        }
    }
}