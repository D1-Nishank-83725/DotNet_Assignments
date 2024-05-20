namespace Question7
{
    class Date
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
}
