using System;

namespace OchoaCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1: THE 4TH MONTH IS " + MonthName(4));
            int[] a = new int[] { 1, 2, 5, 4, 5 };
            Console.WriteLine("Challenge 2: THE MIN AND MAX OF 1-5 IS" + FindMinMax(a));



        }
        public static string MonthName(int a)
        {
            string[] name = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            if (a == 1)
            {
                return name[0];
            }
            else if (a == 2) {
                return name[1];
            } else if (a == 3)
            {
                return name[2];
            }
            else if (a == 4)
            {
                return name[3];
            }
            else if (a == 5)
            {
                return name[4];
            }
            else if (a == 6)
            {
                return name[5];
            }
            else if (a == 7)
            {
                return name[6];
            }
            else if (a == 8)
            {
                return name[7];
            }
            else if (a == 9)
            {
                return name[8];
            }
            else if (a == 10)
            {
                return name[9];
            }
            else if (a == 11)
            {
                return name[10];
            }
            else
            {
                return name[11];
            }

        }
        public static string FindMinMax(int[] a)
        { int min = a[0];
            int max = a[0];
            int alength = a.Length;
            int b = 0;

            while (b < alength)
            {
                if (min > a[b])
                {
                    min = a[b];
                    
                }
                if (max < a[b])
                {
                    max = a[b];
                    
                }
                b++;
            }
            String values = "[" + min + "," + max + "]";
            return values;
        }
    }
}

    
        

