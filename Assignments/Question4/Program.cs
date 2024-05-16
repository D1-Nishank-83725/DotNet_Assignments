using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Question4
{

    public struct Student
    {

        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;


        public Student()
        {
            _name = "";
            _gender = true;
            _age = 0;
            _std = 0;
            _div = '-';
            _marks = 0;
        }
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _std = std;
            _div = div;
            _marks = marks;
        }

        public double Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        public char Div
        {
            get { return _div; }
            set { _div = value; }
        }


        public int Std
        {
            get { return _std; }
            set { _std = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Gender (true: Male, false: Female): ");
            Gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Std: ");
            Std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Div: ");
            Div = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Marks: ");
            Marks = Convert.ToDouble(Console.ReadLine());
        }


        public void PrintDetails()
        {
            Console.WriteLine("Student Details" + Environment.NewLine);
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Gender : " + _gender);
            Console.WriteLine("Age : " + _age);
            Console.WriteLine("Std : " + _std);
            Console.WriteLine("Div : " + _div);
            Console.WriteLine("Marks : " + _marks);
            Console.ReadLine();
        }


    }

    internal class Program
        {
            static void Main(string[] args)
            {

                Student student = new Student();
                student.AcceptDetails();
                student.PrintDetails();
            }
        }
}