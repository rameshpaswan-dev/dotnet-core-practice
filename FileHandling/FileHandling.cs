using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    internal class FileHandling
    {
        public void CreateFile(string filename)
        {
            string file = filename + ".text";

            //get the current directory.
            string path = Directory.GetCurrentDirectory();

            //combile path and filename
            string fullpath = Path.Combine(path, file);

            // create the file

            File.Create(fullpath).Close();

            Console.WriteLine(fullpath);



        }
    }
}
