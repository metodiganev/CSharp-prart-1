using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Age_after_10_Years
{
//Write a program to read your birthday from the console and print how old 
//you are now and how old you will be after 10 years.
    class ageAfterTenYears
    {
        static void Main()
        {

            Console.WriteLine("Enter your birthdate in the format yyyy/mm/dd");
            DateTime bDay = DateTime.Parse(Console.ReadLine());

            
            DateTime todayDate = DateTime.Now;
            int age = (int)((DateTime.Now - bDay).TotalDays / 365.242199);

            Console.WriteLine("My Age is: " + age);            
            Console.WriteLine("My Age after 10 years will be: " + (age+10));
                                  
        }
    }
}
