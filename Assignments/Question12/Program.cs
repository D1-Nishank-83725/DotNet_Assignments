//using System.ComponentModel.DataAnnotations;

//namespace Question12
//{

//    public enum DepartmentType
//    {
//        HR,
//        IT,
//        Sales,
//        Marketing
//    }


//    public class Date
//    {
//        private int _day;
//        private int _month;
//        private int _year;

//        public Date()
//        {
//            _day = 0;
//            _month = 0;
//            _year = 0;
//        }

//        public Date(int day, int month, int year)
//        {
//            Day = day;
//            Month = month;
//            Year = year;
//        }

//        public int Year
//        {
//            get { return _year; }
//            set { _year = value; }
//        }


//        public int Month
//        {
//            get { return _month; }
//            set { _month = value; }
//        }


//        public int Day
//        {
//            get { return _day; }
//            set { _day = value; }
//        }

//        public void AcceptDate()
//        {
//            Console.WriteLine("Enter Day : ");
//            _day = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Month : ");
//            _month = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Day : ");
//            _year = Convert.ToInt32(Console.ReadLine());
//        }

//        public void PrintDate()
//        {
//            Console.WriteLine("Date: " + _day + "/" + _month + "/" + _year);
//        }

//        public bool IsValid()
//        {
//            if ((_day >= 01 && _day <= 31) && (_month >= 01 && _month <= 12) && (_year >= 1900 && _day <= 3000))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public string ToString()
//        {
//            return ("Date: " + _day + "/" + _month + "/" + _year);
//        }


//        public static Date operator -(Date d1, Date d2)
//        {
//            Date d3 = new Date();
//            d3.Day = Math.Abs(d1.Day - d2.Day);
//            d3.Month = Math.Abs(d1.Month - d2.Month);
//            d3.Year = Math.Abs(d1.Year - d2.Year);

//            return d3;
//        }



//    }
//    public class Person
//    {

//        private string _name;
//        private char _gender;
//        private Date _birth;
//        private string _address;
//        private static int _age;

//        public Person()
//        {
//            Name = "";
//            Gender = '-';
//            Birth = new Date();
//            Address = "";
//        }

//        public Person(string address, int day, int month, int year, char gender, string name)
//        {
//            Address = address;
//            Birth = new Date(day, month, year);
//            Gender = gender;
//            Name = name;
//        }

//        public string Address
//        {
//            get { return _address; }
//            set { _address = value; }
//        }


//        public Date Birth
//        {
//            get { return _birth; }
//            set { _birth = value; }
//        }


//        public char Gender
//        {
//            get { return _gender; }
//            set { _gender = value; }
//        }


//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }


//        public virtual void Accept()
//        {
//            Console.WriteLine("Enter Name : ");
//            Name = Console.ReadLine();


//            Console.WriteLine("Enter Gender : ");
//            Gender = Convert.ToChar(Console.ReadLine());


//            Console.WriteLine("Enter Date : ");

//            Console.WriteLine("Enter Day: ");
//            Birth.Day = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter Month: ");
//            Birth.Month = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter Year: ");
//            Birth.Year = Convert.ToInt32(Console.ReadLine());



//            Console.WriteLine("Enter Address: ");
//            Address = Console.ReadLine();
//        }


//        public virtual void Print()
//        {
//            Console.WriteLine("Name: " + Name);
//            Console.WriteLine("Gender: " + Gender);
//            Console.WriteLine("Birth Date: ");
//            Birth.PrintDate();
//            Console.WriteLine("Address: " + Address);
//        }

//        public virtual string ToString()
//        {
//            return ("Name: " + Name + "Gender: " + Gender + " Date: " + Birth.Day + "/" + Birth.Month + "/" + Birth.Year + " Address : " + Address);
//        }


//        public int calculateAge(Date d)
//        {
//            return DateTime.Now.Year - d.Year;

//        }

//    }
//    public class Employee : Person
//    {
//        int id;
//        double salary;
//        string designation;
//        DepartmentType department;
//        static int count = 1;



//        public int Id { get => id; set => id = value; }
//        public double Salary { get => salary; set => salary = value; }
//        public string Designation { get => designation; set => designation = value; }




//        public Employee()
//        {
//            id = count;
//            count++;
//        }

//        public Employee(double salary, string designation, DepartmentType department)
//        {
//            id = count;
//            count++;
//            this.salary = salary;
//            this.designation = designation;
//            this.department = department;
//        }

//        public override string ToString()
//        {
//            return $"Employee ID: {id}, Salary: {salary}, Designation: {designation}, Department: {department}";
//        }

//        public virtual void Accept()
//        {
//            base.Accept();
//            Console.WriteLine();
//            Console.WriteLine("Enter Salary : ");
//            Salary = Convert.ToDouble(Console.ReadLine());


//            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing)");
//            string departmentinput = Console.ReadLine();
//            department = (DepartmentType)Enum.Parse(typeof(DepartmentType), departmentinput, true);

//        }

//        public virtual void Print()
//        {
//            Console.WriteLine("ID: " + Id);
//            Console.WriteLine("Salary: " + Salary);
//            Console.WriteLine("Designation: " + Designation);
//            Console.WriteLine("Department: " + department);

//        }

//        public static implicit operator LinkedListNode<object>(Employee v)
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class Company 
//    {
//        string name;
//        string address;
//        LinkedList<Person> empList;
//        double salaryExpense;

//        public string Name { get => name; set => name = value; }
//        public string Address { get => address; set => address = value; }
//        public LinkedList<Person> EmpList { get => empList; set => empList = value; }
//        public double SalaryExpense { get => salaryExpense; set => salaryExpense = value; }


//        public Company() : base()
//        {
//            EmpList = new LinkedList<Person>();
//        }

//        public Company(string name, string address, LinkedList<Employee> empList, double salaryExpense)
//        {
//            Name = name;
//            Address = address;
//            EmpList = new LinkedList<Person>();
//            SalaryExpense = salaryExpense;

//        }

//        public void Accept()
//        {

//            Console.WriteLine("Enter the Name of the Company: ");
//            Name = Console.ReadLine();

//            Console.WriteLine("Enter the Address of the Company: ");
//            Address = Console.ReadLine();


//            Employee emp = new Employee();
//            Console.WriteLine("Enter Employee Details: ");
//            emp.Accept();
//            AddEmployee(ref emp);

//        }

//        public void AddEmployee(ref Employee e)
//        {
//            empList.AddLast(e);
//            Console.WriteLine("Employee Successfully Added!");

//        }




//        public override string ToString()
//        {
//            return $"{{{nameof(Name)}={Name}, {nameof(Address)}={Address}, {nameof(EmpList)}={EmpList}, {nameof(SalaryExpense)}={SalaryExpense.ToString()}}}";
//        }

//        public void Print()
//        {
//            Console.WriteLine("Company's Name: ");
//            Console.WriteLine("Company's Address: ");
//            Console.WriteLine();
//            Console.WriteLine("Employee's Details: ");

//            foreach (Employee employee in empList)
//            {
//                employee.Print();
//            }
//        }

//        public double CalculateSalaryExpense(LinkedList<Person> empList)
//        {
//            double salaryExpense = 0;

//            foreach (Employee e in empList)
//            {
//                salaryExpense += e.Salary;  
//            }

//            SalaryExpense = salaryExpense;
//            return salaryExpense;

//        }


//        public bool RemoveEmployee(int id)
//        {
//            foreach (Employee e in empList)
//            {
//                if (e.Id.Equals(id))
//                {
//                    empList.Remove(e);
//                    Console.WriteLine("Employee Deleted");
//                    return true;
//                }
//                else
//                {
//                    Console.WriteLine("Employee with Given ID does not exist!");
//                    return false;
//                }
//            }
//            return false;
//        }



//        //public LinkedListNode<Employee> FindEmployee(int id)
//        //{
//        //    LinkedListNode<Employee> employee = null;

//        //    foreach (Employee e in empList)
//        //    {
//        //        if (e.Id.Equals(id))
//        //        {
//        //            employee = e;
//        //        }
//        //    }
//        //    return employee;
//        //}


//        //This logic falters, below given is the correct logic 



//        public LinkedListNode<Person> FindEmployee(int id)
//        {
//            //Pointing to 0th Index
//            LinkedListNode<Person> currentNode = empList.First;

//            while (currentNode != null)
//            {
//                if (currentNode.Value.Id)
//                {
//                    return currentNode;
//                }
//                //Increment Logic
//                currentNode = currentNode.Next;
//            }

//            return null; // Return null if the employee is not found
//        }

//    }


//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Company company = new Company();
//            company.Accept();
//            company.Print();

//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Question12
{
    public enum DepartmentType
    {
        HR,
        IT,
        Sales,
        Marketing
    }

    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date()
        {
            _day = 0;
            _month = 0;
            _year = 0;
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter Day: ");
            _day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month: ");
            _month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            _year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Date: " + _day + "/" + _month + "/" + _year);
        }

        public bool IsValid()
        {
            return (_day >= 1 && _day <= 31) && (_month >= 1 && _month <= 12) && (_year >= 1900 && _year <= 3000);
        }

        public override string ToString()
        {
            return "Date: " + _day + "/" + _month + "/" + _year;
        }

        public static Date operator -(Date d1, Date d2)
        {
            return new Date(Math.Abs(d1.Day - d2.Day), Math.Abs(d1.Month - d2.Month), Math.Abs(d1.Year - d2.Year));
        }
    }

    public class Person
    {
        private string _name;
        private char _gender;
        private Date _birth;
        private string _address;

        public Person()
        {
            Name = "";
            Gender = '-';
            Birth = new Date();
            Address = "";
        }

        public Person(string address, int day, int month, int year, char gender, string name)
        {
            Address = address;
            Birth = new Date(day, month, year);
            Gender = gender;
            Name = name;
        }

        public string Address { get => _address; set => _address = value; }
        public Date Birth { get => _birth; set => _birth = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string Name { get => _name; set => _name = value; }

        public virtual void Accept()
        {
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Gender: ");
            Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Date of Birth: ");
            Birth.AcceptDate();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Birth Date: ");
            Birth.PrintDate();
            Console.WriteLine("Address: " + Address);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Date: {Birth}, Address: {Address}";
        }

        public int CalculateAge(Date d)
        {
            return DateTime.Now.Year - d.Year;
        }
    }

    public class Employee : Person
    {
        int id;
        double salary;
        string designation;
        DepartmentType department;
        static int count = 1;

        public int Id { get => id; set => id = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }

        public Employee()
        {
            id = count;
            count++;
        }

        public Employee(double salary, string designation, DepartmentType department)
        {
            id = count;
            count++;
            this.salary = salary;
            this.designation = designation;
            this.department = department;
        }

        public override string ToString()
        {
            return $"Employee ID: {id}, Salary: {salary}, Designation: {designation}, Department: {department}";
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing): ");
            string departmentInput = Console.ReadLine();
            department = (DepartmentType)Enum.Parse(typeof(DepartmentType), departmentInput, true);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + department);
        }
    }

    public class Company
    {
        string name;
        string address;
        LinkedList<Employee> empList;
        double salaryExpense;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public LinkedList<Employee> EmpList { get => empList; set => empList = value; }
        public double SalaryExpense { get => salaryExpense; set => salaryExpense = value; }

        public Company()
        {
            empList = new LinkedList<Employee>(); // Initialize empList
        }

        public Company(string name, string address, LinkedList<Employee> empList, double salaryExpense)
        {
            Name = name;
            Address = address;
            EmpList = empList;
            SalaryExpense = salaryExpense;
        }

        public void Accept()
        {
            Console.WriteLine("Enter Company Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Company Address: ");
            Address = Console.ReadLine();
        }

        public void AddEmployee(Employee e)
        {
            empList.AddLast(e);
            Console.WriteLine("Employee Successfully Added!");
        }

        public bool RemoveEmployee(int id)
        {
            LinkedListNode<Employee> employeeNode = FindEmployee(id);
            if (employeeNode != null)
            {
                empList.Remove(employeeNode);
                Console.WriteLine("Employee Deleted");
                return true;
            }
            else
            {
                Console.WriteLine("Employee with Given ID does not exist!");
                return false;
            }
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in empList)
            {
                Console.WriteLine(employee);
            }
        }

        public double CalculateSalaryExpense()
        {
            double salaryExpense = 0;
            foreach (Employee e in empList)
            {
                salaryExpense += e.Salary;
            }
            SalaryExpense = salaryExpense;
            return salaryExpense;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            LinkedListNode<Employee> currentNode = empList.First;
            while (currentNode != null)
            {
                if (currentNode.Value.Id == id)
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Salary Expense: {SalaryExpense}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
            PrintEmployees();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();
            company.Print();
            Employee emp = new Employee();
            emp.Accept(); // Accept employee details
            company.AddEmployee(emp);
            company.Print();
            double companyExpense = company.CalculateSalaryExpense();
            Console.WriteLine("Company's Expense : " + companyExpense);

            Console.WriteLine("Enter the ID of the Employee you want to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            //company.Print();
            company.RemoveEmployee(id);
            company.Print();
            //company.Print();

        }
    }
}
