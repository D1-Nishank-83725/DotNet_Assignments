using System;

namespace Question10
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
        string designation = "Supervisor";
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

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Supervisor supervisor = new Supervisor();
            supervisor.Accept();
            supervisor.Print();

        }
    }
}


