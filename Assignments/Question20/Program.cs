namespace Question20
{
    public delegate void EmployeeChange();
    internal class Program
    {
        static int Menu()
        {
            int choice;
            Console.WriteLine("-----Company Menu-----");
            Console.WriteLine("0. Press to Exit");
            Console.WriteLine("1. Press to Add Employee");
            Console.WriteLine("2. Press to Remove Employee");
            Console.WriteLine("3. Press to Find Employee by id");
            Console.WriteLine("4. Press to Display Company Info");
            Console.WriteLine("5. Press to Display all Employeees");
            Console.WriteLine("Enter Choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice; ;
        }
        static void Main(string[] args)
        {
            Company company = new Company();
            EmployeeChange dele = new EmployeeChange(company.CalculateSalaryExpense);
            company.FinaceReCheck += dele;
            company.Accept();
            int ch;
            while ((ch = Menu()) != 0)
            {
                switch (ch)
                {
                    case 1:
                        company.AddEmployee(new Employee());
                        break;
                    case 2:
                        Console.WriteLine("Enter id of Employee to Fire:");
                        company.RemoveEmployee(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter id of Employee to Find:");
                        LinkedListNode<Employee> emp = company.FindEmployee(Convert.ToInt32(Console.ReadLine()));
                        if (emp != null)
                        {
                            Console.WriteLine(emp.Value);
                        }
                        else
                        {
                            Console.WriteLine("No Such EMployee Found");
                        }
                        break;
                    case 4:
                        company.Print();
                        break;
                    case 5:
                        company.PrintEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            Console.WriteLine("Thanks for Using");
        }
    }
}

#region Code-Output
/*
## Company Accept ###
Enter Company Name:
DAC
Enter Address:
Pune
-----Company Menu-----
0. Press to Exit
1. Press to Add Employee
2. Press to Remove Employee
3. Press to Find Employee by id
4. Press to Display Company Info
5. Press to Display all Employeees
Enter Choice:
1
Enter Name:
Pritesh
Enter Gender (Male:True,Female:false):
true
Enter Day:
05
Enter Month:
06
Enter Year:
2010
Enter Address:
Goa
Enter Salary:
8500
Enter Department (1:Sales,2:Dev,3:HR):
2
Re-Calculation Event Fired
-----Company Menu-----
0. Press to Exit
1. Press to Add Employee
2. Press to Remove Employee
3. Press to Find Employee by id
4. Press to Display Company Info
5. Press to Display all Employeees
Enter Choice:
2
Enter id of Employee to Fire:
1
Employee Removed
Re-Calculation Event Fired
-----Company Menu-----
0. Press to Exit
1. Press to Add Employee
2. Press to Remove Employee
3. Press to Find Employee by id
4. Press to Display Company Info
5. Press to Display all Employeees
Enter Choice:
4
## Company Print ###
Company Name:DAC
Company Address:Pune
Company Employees:
Salary Expenses:0
-----Company Menu-----
0. Press to Exit
1. Press to Add Employee
2. Press to Remove Employee
3. Press to Find Employee by id
4. Press to Display Company Info
5. Press to Display all Employeees
Enter Choice:
1
Enter Name:
Vaibhav
Enter Gender (Male:True,Female:false):
true
Enter Day:
06
Enter Month:
05
Enter Year:
2010
Enter Address:
Goa
Enter Salary:
8500
Enter Department (1:Sales,2:Dev,3:HR):
2
Re-Calculation Event Fired
-----Company Menu-----
0. Press to Exit
1. Press to Add Employee
2. Press to Remove Employee
3. Press to Find Employee by id
4. Press to Display Company Info
5. Press to Display all Employeees
Enter Choice:
4
## Company Print ###
Company Name:DAC
Company Address:Pune
Company Employees:
ID:2
Name:Vaibhav
Gender:Male
Birth:6/5/2010
Address:Goa
Age:14
Salary: 8500
Designation: Wage
Department: Development
Salary Expenses:8500
-----Company Menu-----
0. Press to Exit
1. Press to Add Employee
2. Press to Remove Employee
3. Press to Find Employee by id
4. Press to Display Company Info
5. Press to Display all Employeees
Enter Choice:
0
Thanks for Using
 */
#endregion