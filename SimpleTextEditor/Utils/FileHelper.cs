using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleTextEditor.Utils
{
    internal class FileHelper
    {
        public static readonly string BaseDirectory = Path.Combine(Directory.GetCurrentDirectory(), "EditorFiles");
        
        
        static FileHelper()
        {
            if (!Directory.Exists(BaseDirectory))
            {
                Directory.CreateDirectory(BaseDirectory);
            }

        }
        

        // validation file 

        public static bool IsVailidFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return false;
            }

            // Allow only letters,numbers,underscore
            return Regex.IsMatch(fileName, @"^[a-zA-Z0-9_]+$"); 
        }
        
        // safe file existance check 
        public static bool IsFile(string fileName)
        {
            if (!IsVailidFileName(fileName))
                throw new ArgumentException("Invalid  file name.");
                
            string path = GetFilePath(fileName);
            return File.Exists(path);
        }

        // Scecure Path generation  
        public static string GetFilePath(string fileName)
        {

            if (!IsVailidFileName(fileName))
            {
                throw new ArgumentException("Invalid file name.");
            }
           
            return Path.Combine(BaseDirectory, fileName+".txt");
        }


        // optional: Make file read-only
        public static void MakeReadOnly(string fileName)
        {
            String path = GetFilePath(fileName);
            if(File.Exists(path))
            {
                File.SetAttributes(path, FileAttributes.ReadOnly);
            }
        }
    }
}
