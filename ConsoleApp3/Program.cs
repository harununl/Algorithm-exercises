
using System;

namespace AccessArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string hour;
            string minute;
            string second;
            string dayPart = "";
         


            Console.Write("enter time..\n");
            
            hour = Console.ReadLine();
            minute = Console.ReadLine();
            second = Console.ReadLine();
            dayPart = Console.ReadLine();

            Console.WriteLine(hour + ":" + minute + ":" + second + dayPart);

            if (dayPart == "PM")
            {
                hour = hour + "12";
                Console.WriteLine("converted time is\n");
                Console.WriteLine(hour + ":" + minute + ":" + second);

            }
            else if(dayPart == "AM")
            {
                Console.WriteLine(hour + ":" + minute + ":" + second);
            }
           

        }
    }
}
