using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace first_project
{
    internal class Manager : Admin
    {
        protected double salary;
        internal Manager(int id, string name,double salary) : base(id, name)
        {
            this.salary = salary;
        }

        public void ShowManager()
        {
            Console.WriteLine($"Id: {id}, Name: {name}, Salary: {salary}");
        }
    }
}
