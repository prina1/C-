using System;

//define an enum named Days 
namespace Enums
{
    enum Days 
    {
        sunday, 
        monday, 
        tuesday,
        wednesday,
        thursday,
        friday, 
        saturday
    }

    class Program
    {
        static void Main()
        {
            //using days enum
            Days today = Days.wednesday;

            //Display the value of today
            Console.WriteLine("today is:" + today);
            Console.WriteLine("The value of wednesday in day is:" +(int) Days.wednesday);

            //check if today is weeked day
            if(IsWeekday(today))
            {
                Console.WriteLine("today is a weekday");
            }
            else
            {
                Console.WriteLine("today is a weekend day");
            }
        }

        //function to check if a given day is week day
        static bool IsWeekday(Days day)
        {
            //check if day is not saturday and sunday
            return day != Days.saturday && day != Days.sunday;
        }
    }
}