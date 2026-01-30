using System;
using System.Collections.Generic;
using System.Text;

namespace first_project
{
    internal class InheritClass : Interface1, Interface2
    {
        public void Details()
        {
            Console.WriteLine("Desplay Records.");
        }

        public void Fun()
        {
            Console.WriteLine("Fun method");
        }

        public void Show()
        {
            Console.WriteLine("Show method.");
        }
    }
}
