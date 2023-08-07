using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace Binary_Ser_And_Dser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Id");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee First Name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Employee Last Name");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            employee.Salary=double.Parse(Console.ReadLine());

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D:\\C# Programme\\Day-21\\Assignment_24\\Binary_Ser_And_Dser\\employee.bin", FileMode.Create))
            {
                formatter.Serialize(fs, employee);
            }
            Console.WriteLine("Created and Serilized");
            Console.ReadKey();


        }
    }
}
