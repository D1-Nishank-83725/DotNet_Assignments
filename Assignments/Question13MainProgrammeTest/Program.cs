using Question13;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Question14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Program!");
            Console.WriteLine();

            Company company = new Company();
            company.Accept();

            int choice;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add Employee to Company: ");
                Console.WriteLine("2. Find Employee by ID: ");
                Console.WriteLine("3. Display Company Info: ");
                Console.WriteLine("4. Display All Employees: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank you for using the Programme!");
                        Environment.Exit(0);
                        break;

                    case 1:
                        Employee employee = new Employee();
                        employee.Accept();
                        company.AddEmployee(employee);
                        company.CalculateSalaryExpense();
                        break;

                    case 2:
                        Console.WriteLine("Find Employee using ID");
                        int id = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<Employee> employeefoundusingID = company.FindEmployee(id);
                        Console.WriteLine(employeefoundusingID.Value.ToString());
                        break;

                    case 3:
                        company.Print();
                        break;

                    case 4:
                        company.PrintEmployees();
                        break;
                }



            }




        }
    }
}
