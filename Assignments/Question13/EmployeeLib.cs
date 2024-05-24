namespace Question13
{


    public enum DepartmentType
    {
        HR,
        IT,
        Sales,
        Marketing
    }


    public class Person
    {

        private string _name;
        private char _gender;
        private Date _birth;
        private string _address;
        private static int _age;

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

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public Date Birth
        {
            get { return _birth; }
            set { _birth = value; }
        }


        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public virtual void Accept()
        {
            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();


            Console.WriteLine("Enter Gender : ");
            Gender = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Enter Date : ");

            Console.WriteLine("Enter Day: ");
            Birth.Day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month: ");
            Birth.Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year: ");
            Birth.Year = Convert.ToInt32(Console.ReadLine());



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

        public virtual string ToString()
        {
            return ("Name: " + Name + "Gender: " + Gender + " Date: " + Birth.Day + "/" + Birth.Month + "/" + Birth.Year + " Address : " + Address);
        }


        public int calculateAge(Date d)
        {
            return DateTime.Now.Year - d.Year;

        }

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
            Console.WriteLine("Enter Day : ");
            _day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month : ");
            _month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Day : ");
            _year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Date: " + _day + "/" + _month + "/" + _year);
        }

        public bool IsValid()
        {
            if ((_day >= 01 && _day <= 31) && (_month >= 01 && _month <= 12) && (_year >= 1900 && _day <= 3000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToString()
        {
            return ("Date: " + _day + "/" + _month + "/" + _year);
        }


        public static Date operator -(Date d1, Date d2)
        {
            Date d3 = new Date();
            d3.Day = Math.Abs(d1.Day - d2.Day);
            d3.Month = Math.Abs(d1.Month - d2.Month);
            d3.Year = Math.Abs(d1.Year - d2.Year);

            return d3;
        }



    }

    public class Employee : Person
    {
        int id;
        double salary;
        string designation = "Manager";
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

        override public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing)");
            string departmentinput = Console.ReadLine();
            department = (DepartmentType)Enum.Parse(typeof(DepartmentType), departmentinput, true);

        }

        override public void Print()
        {
            base.Print();
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + department);

        }
    }


    public class Manager : Employee
    {
        private double bonus;
        public double Bonus { get => bonus; set => bonus = value; }

        public Manager() : base() { }

        public Manager(double salary, DepartmentType department, double bonus) : base(salary, "Manager", department)
        {
            this.bonus = bonus;
        }

        override public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Bonus: ");
            bonus = Convert.ToDouble(Console.ReadLine());
        }

        override public void Print()
        {
            base.Print();
            Console.WriteLine("Bonus : " + bonus);
        }

        public override string ToString()
        {
            return $"Bonus: {Bonus}";
        }
    }

    public class Supervisor : Employee
    {
        private int subbordinates;

        public int Subbordinates { get => subbordinates; set => subbordinates = value; }


        public Supervisor() { }

        public Supervisor(int subbordinates)
        {
            this.subbordinates = subbordinates;
        }


        //public Supervisor() : base() { }

        //public Supervisor(double salary, DepartmentType department, int subbordinates) : base(salary, "Supervisor", department)
        //{
        //    this.subbordinates = subbordinates;
        //}


        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Number of Subbordinates: ");
            Subbordinates = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            base.Print(); ;
            Console.WriteLine("Subbordinates : " + Subbordinates);
        }


    }


    public class WageEmp : Employee
    {
        int hours;
        int rate;

        public WageEmp() : base()
        {

        }

        public WageEmp(double salary, DepartmentType department, int hours, int rate) : base(salary, "Wage", department)
        {
            this.Hours = hours;
            this.Rate = rate;
        }

        public int Hours { get => hours; set => hours = value; }
        public int Rate { get => rate; set => rate = value; }



        public void Accept()
        {
            base.Accept();

            Console.WriteLine("Enter Number of Hours Worked: ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate of Employee per Hour: ");
            Rate = Convert.ToInt32(Console.ReadLine());

        }

        public void Print()
        {

            base.Print();
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{{{nameof(Hours)}={Hours.ToString()}, {nameof(Rate)}={Rate.ToString()}}}";
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
                //Console.WriteLine(employee);
                Console.WriteLine(employee.ToString());
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
            //PrintEmployees();
        }
    }


    public class EmployeeLib
    {
    }
}
