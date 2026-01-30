using System;
using System.Collections.Generic;
using System.Text;

namespace first_project
{
    internal class ConstructoeExample
    {
        static ConstructoeExample()
        {
            Console.WriteLine("static construcor");
        }

        internal ConstructoeExample()
        {
            Console.WriteLine("Default constructore");
        }

        internal ConstructoeExample(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
