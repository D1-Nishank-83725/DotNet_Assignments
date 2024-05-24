namespace Question8
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
        string designation;
        DepartmentType department;
        static int count = 1;



        public int Id { get => id; set => id = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }




        public Employee() {
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

        public void Accept()
        {

            base.Accept();

            Console.WriteLine("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Designation : ");
            Designation = Console.ReadLine();


            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing)");
            //string departmentinput = Console.ReadLine();
            department = (DepartmentType)  Enum.Parse(typeof(DepartmentType), Console.ReadLine());

        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + department);

        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
    
            employee.Accept();
            employee.Print();
        }
    }





}
