using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace first_project
{
    internal class Admin
    {
        protected int id;
        protected string name;
        internal Admin(int id,string name) {
            this.id = id;
            this.name = name;
        }

        public void ShowAdmin()
        {
            Console.WriteLine($"Id: {id}, Name: {name}");
        }
    }
}
