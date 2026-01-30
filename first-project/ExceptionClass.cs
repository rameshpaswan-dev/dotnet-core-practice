using System;

namespace first_project
{
    internal class ExceptionClass
    {
        internal double ShowData(int a, int b)
        {
            try
            {
                int c = a/b;
                Console.WriteLine("This is Output: "+c);
                return c;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return 0; // default value
            }
        }
    }
}
