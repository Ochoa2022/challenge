using System;

namespace OchoaCodingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1:" + Sum( 1,5));
            Console.WriteLine("Challenge 2:" + Convert(5));
            Console.WriteLine("Challenge 3:" + PlusOne(3));
            Console.WriteLine("Challenge 4:" + CircuitPower(230, 10));
            Console.WriteLine("Challenge 5:" + CalcAge(65));
            Console.WriteLine("Challenge 6:" + triArea(3,2));
            Console.WriteLine("Challenge 7:" + lessThanOrEqualToZero(5));
            Console.WriteLine("Challenge 8:" + lessThan100(22,15));
            Console.WriteLine("Challenge 9: A. " + IsEqual(5, 6) + " B."+ IsEqual(1,1));
            Console.WriteLine("Challenge 10: A. " + GiveMeSomething("is better than nothing") + " B. " + GiveMeSomething("Bob Jane") + " C." + GiveMeSomething("something"));
            Console.WriteLine("Challenge 11: A. " + Reverse("true") + " B. " + Reverse("false"));
            Console.WriteLine("Challenge 12: " + HowManySeconds(2));
            Console.WriteLine("Challenge 13: A. " + SumPolygon(3) + " B. " + SumPolygon(4) + " C." + SumPolygon(6));
            Console.WriteLine("Challenge 14: A. " + nameString("Mubashir") + " B. " + nameString("Matt") + " C. " + nameString("C#"));
            Console.WriteLine("Challenge 15 A. " + And(true, false) + " B. " + And(true, true) + " C. " + And(false, true) + " D. " + And(false, false));
            Console.WriteLine("Challenge 16: A. " + points(1,1) + " B. " + points(7,5));
            Console.WriteLine("Challenge 17: A. " + FindPerimeter(6,7) + " B. " + FindPerimeter(20, 10));
            Console.WriteLine("Challenge 18: A. " + HelloName("Gerald") + " B. " + HelloName("Tiffany"));
            Console.WriteLine("Challenge 19: A. " + animals( 2, 3, 5) + " B. " + animals(1, 2, 3));
            Console.WriteLine("Challenge 20: A. " + FootballPoints(3,4,2) + " B. " + FootballPoints(5,0,2));


        }
        public static int Sum( int a, int b)
        {
            return a + b;
        }
        public static int Convert( int minutes)
        {
            return minutes * 60;
        }
        public static int PlusOne( int a)
        {
            return a + 1;
        }
        public static int CircuitPower( int voltage, int current)
        {
            return voltage * current;
        }
        public static int CalcAge(int years)
        {
            return years * 365;
        }
        public static int triArea(int ba, int height)
        {
            return (ba * height) / 2;
        }
        public static bool lessThanOrEqualToZero(int a)
        {
            if (a <= 0)
                return true;
            else return false;
        }
        public static bool lessThan100(int a, int b)
        {
            if ((a + b) < 100)
                return true;
            else return false;
        }
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
                return true;
            else return false;
        }
        public static string GiveMeSomething( string str1)
        {
             string b = "something ";
            return str1 = b + str1;
        }
        public static bool Reverse( string a)
        {
            if (a == "false")
                return true;
            else return false;
        }
        public static int HowManySeconds(int hours)
        {
            return hours * 60 * 60;
        }
        public static int SumPolygon(int n)
        {
            return (n - 2) * 180;
        }
        public static string nameString( string a)
        {
            string b = " Edabit";
            string result= a + b;
            return result;
        }
        public static bool And( bool a, bool b)
        {
            if (a && b)
                return true;
            else return false;
        }
        public static int points(int a, int b)
        {
            a = a * 2;
            b = b * 3;
            return a + b;
        }
        public static int FindPerimeter(int a, int b)
        {
            return (a + b) * 2;
        }
        public static string HelloName(string a)
        {
            string b = "Hello ";
            return a = b + a;
        }
        public static int animals(int c, int cow, int p)
        {
            c = c * 2;
            cow = cow * 4;
            p = p * 4;
            return p + cow + c;
        }
        public static int FootballPoints(int win, int draws, int loss)
        {
            win = win * 3;
            draws = draws * 1;
            loss = loss * 0;
            return win + draws + loss;
        }

    }

}
