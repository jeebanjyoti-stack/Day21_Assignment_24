using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace XML_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee {Id=105, FirstName="David", LastName="Beckham", Salary=100000};

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("D:\\C# Programme\\Day-21\\Assignment_24\\XML_Serialization\\employee.xml"))
            {
                serializer.Serialize(writer, employee);
            }
            Console.WriteLine("Employee Details Added Successfully");
            Console.ReadKey();
        }
    }
}
