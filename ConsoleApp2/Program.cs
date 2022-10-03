
using System;

namespace AccessArray
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isLeapYear;
            int year;
            int months = 5 * 31 + 2 * 30;
            
            int dd;
            int mm = 09;
            int yyyy;
            int feb;
            int temp = 0;


            Console.Write("enter year\n");

            year = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("your choice is  " + year);

            if (year % 4 == 0)
            { isLeapYear = true;
                feb = 29;
                temp = months + feb;
                temp = 256 - temp;
                dd= temp;
                yyyy = year;
                Console.WriteLine(dd + "." + "09" + "." + year);



            }

            else
            {
                feb = 28;
                temp = months + feb;
                temp = 256 - temp;
                dd = temp;
                yyyy = year;
                Console.WriteLine(dd + "." + "09" + "." + year);
            }



            

        }
    }
}
