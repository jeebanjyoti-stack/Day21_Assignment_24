using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace XML_ReadOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextReader reader = new StreamReader("D:\\C# Programme\\Day-21\\Assignment_24\\XML_Serialization\\employee.xml"))
            {
                Employee deserializedPerson = (Employee)serializer.Deserialize(reader);
                Console.WriteLine($"ID: {deserializedPerson.Id}");
                Console.WriteLine($"Name: {deserializedPerson.FirstName} {deserializedPerson.LastName}");
                Console.WriteLine($"Salary: {deserializedPerson.Salary}");
            }
            Console.ReadKey();
        }
    }
}
