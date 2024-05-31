namespace Question18
{
    static class MathStatic
    {
        public static int Add(int x,int y)
        {
            Console.WriteLine("Invoked Add");
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            Console.WriteLine("Invoked Sub");
            return x - y;
        }
        public static int Mul(int x, int y)
        {
            Console.WriteLine("Invoked Mul");
            return x * y;
        }
        public static int Div(int x, int y)
        {
            Console.WriteLine("Invoked Div");
            if (y < 0)
                return 0;
            return x / y;
        }
    }
}
