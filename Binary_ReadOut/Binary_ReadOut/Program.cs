using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace Binary_ReadOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("D:\\C# Programme\\Day-21\\Assignment_24\\Binary_Ser_And_Dser\\employee.bin", FileMode.Open))
            {
                Employee ep = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("Employee ID: "+ ep.Id);
                Console.WriteLine("Employee First Name: " + ep.FirstName);
                Console.WriteLine("Employee Last Name: " + ep.LastName);
                Console.WriteLine("Employee Salary: " + ep.Salary);
            }
            Console.ReadKey();
        }
    }
}
