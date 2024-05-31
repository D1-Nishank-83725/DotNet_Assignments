
using EmployeeLib;
using System.Runtime.Serialization.Formatters.Soap;

namespace Question17
{
    internal class Program
    {
        static int Menu()
        {
            int choice;
            Console.WriteLine("-----Company Menu-----");
            Console.WriteLine("0. Press to Exit");
            Console.WriteLine("1. Press to Serialize Company Data");
            Console.WriteLine("2. Press to Deserialize Data From File");
            Console.WriteLine("3. Press to Add Employee");
            Console.WriteLine("4. Press to Remove Employee");
            Console.WriteLine("5. Press to Print Company Data");
            Console.Write("Enter Choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        static void Main(string[] args)
        {
            string filepath = @"C:\DataLogs\company.xml";
            FileStream fs = null;
            Company company = null;
            fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            if (fs.Length == 0)
            {
                Console.WriteLine("Creating New Data");
                company = new Company();
                company.Accept();
                Console.Write("Enter no of Employees:");
                int count = Convert.ToInt32(Console.ReadLine());
                while (count > 0)
                {
                    company.AddEmployee(new Employee());
                    count--;
                }
            }
            else
            {
                Console.WriteLine("Found Pre-exisiting Data.....");
                company = (Company)sf.Deserialize(fs);
            }
            fs.Close();
            int ch;
            while ((ch = Menu()) != 0)
            {
                switch (ch)
                {
                    case 1:
                        fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
                        sf.Serialize(fs, company);
                        fs.Close();
                        Console.WriteLine("Content Serialized into File");
                        break;
                    case 2:
                        fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
                        company = (Company)sf.Deserialize(fs);
                        fs.Close();
                        Console.WriteLine("Content Deserialized into File");
                        break;
                    case 3:
                        company.AddEmployee(new Employee());
                        break;
                    case 4:
                        Console.WriteLine("Enter id of Employee to Remove:");
                        company.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        company.PrintEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            sf = null;
            Console.WriteLine("Thanks for Using");
            Console.ReadLine();
        }
    }
}
#region Code-Output
/*
 Before Serialization
Creating New Data
## Company Accept ###
Enter Company Name:
SOAPTest
Enter Address:
Pune
Enter no of Employees:0
-----Company Menu-----
0. Press to Exit
1. Press to Serialize Company Data
2. Press to Deserialize Data From File
3. Press to Add Employee
4. Press to Remove Employee
5. Press to Print Company Data
Enter Choice:1
Content Serialized into File
-----Company Menu-----
0. Press to Exit
1. Press to Serialize Company Data
2. Press to Deserialize Data From File
3. Press to Add Employee
4. Press to Remove Employee
5. Press to Print Company Data
Enter Choice:3
Enter Name:
Pritesh
Enter Gender (Male:True,Female:false):
True
Enter Day:
05
Enter Month:
06
Enter Year:
1999
Enter Address:
Goa
Enter Salary:
8500
Enter Department (1:Sales,2:Dev,3:HR):
2
-----Company Menu-----
0. Press to Exit
1. Press to Serialize Company Data
2. Press to Deserialize Data From File
3. Press to Add Employee
4. Press to Remove Employee
5. Press to Print Company Data
Enter Choice:1
Content Serialized into File
-----Company Menu-----
0. Press to Exit
1. Press to Serialize Company Data
2. Press to Deserialize Data From File
3. Press to Add Employee
4. Press to Remove Employee
5. Press to Print Company Data
Enter Choice:0
Thanks for Using

 After Serialization
Found Pre-exisiting Data.....
-----Company Menu-----
0. Press to Exit
1. Press to Serialize Company Data
2. Press to Deserialize Data From File
3. Press to Add Employee
4. Press to Remove Employee
5. Press to Print Company Data
Enter Choice:5
ID:1
Name:Pritesh
Gender:Male
Birth:5/6/1999
Address:Goa
Age:25
Salary: 8500
Designation: Wage
Department: Development
-----Company Menu-----
0. Press to Exit
1. Press to Serialize Company Data
2. Press to Deserialize Data From File
3. Press to Add Employee
4. Press to Remove Employee
5. Press to Print Company Data
Enter Choice:0
Thanks for Using
*/
#endregion