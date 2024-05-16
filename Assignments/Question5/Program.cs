using System.Transactions;
using System.Xml.Linq;

namespace Question5
{
    internal class Program
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


}
        static Student[] CreateArray()
        {
            Console.WriteLine("Enter the Size of Student Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] studentarr = new Student[size];
            return studentarr;
        }




        static void AcceptDetails(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");

                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Gender (true/false): ");
                bool gender = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Std: ");
                int std = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter Div: ");
                char div = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Marks: ");
                double marks = Convert.ToDouble(Console.ReadLine());

                students[i] = new Student(name, gender, age, std, div, marks);
            }
            
        }


        static void PrintDetails(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student Details of " + (i+1) + " Student" + Environment.NewLine);
                Console.WriteLine("Name : " + students[i].Name);
                Console.WriteLine("Gender : " + students[i].Gender);
                Console.WriteLine("Age : " + students[i].Age);
                Console.WriteLine("Std : " + students[i].Std);
                Console.WriteLine("Div : " + students[i].Div);
                Console.WriteLine("Marks : " + students[i].Marks);
                Console.WriteLine();
            }

        }


        static void ReverseArray(Student[] students)
        {
            int start = 0;
            int end = students.Length - 1;

            while (start < end)
            {
                Student student = students[start];
                students[start] = students[end];
                students[end] = student;
                start++;
                end--;
            }
                
        }




        static void Main(string[] args)
        {
            Student[] studentarr = CreateArray();

            AcceptDetails(studentarr);

            Console.WriteLine("Enter Enter to Print the Original Students Array: ");
            Console.ReadLine();

            Console.WriteLine("Student List: (Original): ");
            PrintDetails(studentarr);

            Console.WriteLine("Enter Enter to Print the Reversed Students Array: ");
            Console.ReadLine();

            Console.WriteLine("Student List: (Reversed): ");
            ReverseArray(studentarr);
            PrintDetails(studentarr);



        }
    }


}
