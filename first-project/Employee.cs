using System.Xml.Linq;

namespace first_project
{
    internal class Employee : Manager
    {
        protected double incentive;

        internal Employee(int id, string name, double salary, double incentive)
            : base(id, name, salary)
        {
            this.incentive = incentive;
        }

        public void ShowEmployee()
        {
            Console.WriteLine($"Id: {id}, Name: {name}, Salary: {salary}, incentive: {incentive}");
        }
    }
}
