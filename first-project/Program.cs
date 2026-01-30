// See https://aka.ms/new-console-template for more information
using first_project;

Console.WriteLine("Hello, World!");
/*
Hello hello = new Hello();
hello.getName("Ramesh Paswan");*/
//ConstructoeExample example = new ConstructoeExample("Hello");

B b = new B();
b.Fun();
b.Fun1();
Employee emp = new Employee(101, "Ramesh Paswan", 98000, 200000);
emp.ShowAdmin();
emp.ShowManager();
emp.ShowEmployee();
Shape sp = new Rectangle();
Console.WriteLine("Rectangle Area: " + sp.Area(10, 20));

Shape sp1 = new Circle();
Console.WriteLine("Circle Area: " + sp1.Area(5, 0));

Interface1 i1 = new InheritClass();

Interface2 i2   = new InheritClass();

i1.Fun();
i1.Show();
i2.Fun();
i2.Show();
ExceptionClass ex  = new ExceptionClass();
ex.ShowData(10, 0);
ex.ShowData(30, 5);


