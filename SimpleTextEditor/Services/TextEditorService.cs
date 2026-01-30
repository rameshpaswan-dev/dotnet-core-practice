using SimpleTextEditor.interfaces;
using SimpleTextEditor.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor.Services
{
    internal class TextEditorService : ITextEditor
    {
        public void AppendText(string fileName, string content)
        {
            string path = FileHelper.GetFilePath(fileName); 

            if(!File.Exists(path))
            {
                Console.WriteLine($"{fileName} file does not exist");
                return;
            }
            File.AppendAllText(path, content);
            Console.WriteLine("Text appedn successefully.");
        }

        //create file
        public void CreateFile(string fileName)
        {
            string path = FileHelper.GetFilePath(fileName);
            if (File.Exists(path))
            {
                Console.WriteLine("File alrady exist.");
                return;
            }

            File.Create(path).Close();
            Console.WriteLine("File created successefully.");
        }

        // delete file
        public void DeleteText(string fileName)
        {
            string path = FileHelper.GetFilePath(fileName);
            
            if(!File.Exists (path))
            {
                Console.WriteLine($"{fileName} file does not exist");
                return;
            }
            File.Delete(path);
            Console.WriteLine($"{fileName} file delete successefully.");
        }



        // read file
        public void ReadText(string fileName)
        {
            string path = FileHelper.GetFilePath(fileName);
            if(!File.Exists(path))
            {
                Console.WriteLine($"{fileName} file does not exist");
                return;          
            }
            Console.WriteLine("\n----------- file content-----");
            Console.WriteLine(File.ReadAllText(path));
        }

        //write file text
        public void WriteText(string fileName, string content)
        {
           string path=  FileHelper.GetFilePath(fileName);

            if (!File.Exists(path))
            {
                Console.WriteLine($"{fileName} file does not exist");
                return;
            }
            File.WriteAllText(path, content);
            Console.WriteLine("Text written successefully.");
        }
    }
}
