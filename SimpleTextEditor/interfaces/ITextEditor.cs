using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor.interfaces
{
    internal interface ITextEditor
    {
        void CreateFile(string fileName);
        void WriteText(string fileName,string content);
        void ReadText(string fileName);
        void AppendText(string fileName,string content);
        void DeleteText(string fileName);
    }
}
