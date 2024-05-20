using System.Threading.Channels;

namespace Question7
{
    internal class Program
    {
        class Person
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


            public void Accept()
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


            public void Print()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Gender: " + Gender);
                Console.WriteLine("Birth Date: ");
                Birth.PrintDate();
                Console.WriteLine("Address: " + Address);
            }

            public string ToString()
            {
                return ("Name: " + Name + "Gender: " + Gender + " Date: " + Birth.Day + "/" + Birth.Month + "/" + Birth.Year + " Address : " + Address);
            }


            public int calculateAge(Date d)
            {
                return DateTime.Now.Year - d.Year;

            }

        }

        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Accept();
            p1.Print();


            int age = p1.calculateAge(p1.Birth);
            Console.WriteLine("Age of Person: " + age);
            

        }
    }


}
