
namespace Assignment1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Enter the First Number");
                String n1 = Console.ReadLine();
                int num1 = Convert.ToInt32(n1);

                Console.WriteLine("Enter the Second Number");
                String n2 = Console.ReadLine();
                int num2 = Convert.ToInt32(n2);

                Console.WriteLine();
                Console.WriteLine("1: Press '+' for Addition ");
                Console.WriteLine("2: Press '-' for Subtraction ");
                Console.WriteLine("3: Press '*' for Multiplication ");
                Console.WriteLine("4: Press '/' for Division ");
                Console.WriteLine();
                String cce = Console.ReadLine();

                switch (cce)
                {
                    case "+":
                        Console.WriteLine("The Addition of " + num1 + " + " + num2 + " = " + (num1 + num2));
                        break;

                    case "-":
                        Console.WriteLine("The Subtraction of " + num1 + " - " + num2 + " = " + (num1 - num2));
                        break;

                    case "*":
                        Console.WriteLine("The Multiplication of " + num1 + " * " + num2 + " = " + (num1 * num2));
                        break;

                    case "/":
                        Console.WriteLine("The Division of " + num1 + " / " + num2 + " = " + (num1 / num2));
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;

                }


                Console.WriteLine("Press 'e' to Exit, any other key to Continue: ");
                String exitornot = Console.ReadLine();
                if (exitornot == "e")
                {
                    Console.WriteLine("Thank you for using the Programme");
                    Environment.Exit(0);
                }



            } while (true);




        }
    }
}

