// See https://aka.ms/new-console-template for more information
using ConsoleAppTwo;

List<Employee> employees = new List<Employee>()
{
    new Employee() { Id=1,Name="Rohit",Designation="Developer",DOJ=new DateTime(day:12,month:11,year:2022)},
    new Employee() { Id=2,Name="Rocky",Designation="Developer",DOJ=new DateTime(day:22,month:11,year:2022)},
    new Employee() { Id=3,Name="Rohni",Designation="Manager",DOJ=new DateTime(day:2,month:11,year:2022)},
    new Employee() { Id=4,Name="Rohan",Designation="Developer",DOJ=new DateTime(day:12,month:11,year:2022)},
};
Console.WriteLine("ID\t Name \t Designation \t DOJ");
foreach(Employee emp in employees)
{
    Console.Write(emp.Id+"\t \t");
    Console.Write(emp.Name+ "\t \t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.DOJ.ToLongDateString());
}
Console.ReadKey();