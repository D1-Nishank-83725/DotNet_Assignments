namespace Question11
{
    public enum DepartmentType
    {
        HR,
        IT,
        Sales,
        Marketing
    }

    public class Employee
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

        public virtual void Accept()
        {

            Console.WriteLine("Enter Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing)");
            string departmentinput = Console.ReadLine();
            department = (DepartmentType)Enum.Parse(typeof(DepartmentType), departmentinput, true);

        }

        public virtual void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + department);

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


    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();
            wageEmp.Print();

        }
    }


}
