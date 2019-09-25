using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age, i;
            int sum = 0;
            int[] subjects = new int[5];
            String[] subName = new string[5] { "English", "Urdu", "Islamiat", "Physics", "Chemistry" };
            double perc = 0;

            Console.WriteLine ("Enter your Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            age = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < subName.Length; i++)
            {
                Console.WriteLine("Enter your " + subName[i] + " marks");
                subjects[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int marks in subjects)
            {
                sum = sum + marks;
            }
            perc = ((double)sum / 500) * 100;
            Console.WriteLine("Name: " + name + "\nAge: " + age + "\nTotal Marks: " + sum + " out of 500\nPercentage is: " + perc + "%");

            if (perc >= 90 && perc <= 100)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (perc >= 80 && perc < 90)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (perc >= 70 && perc < 80)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (perc >= 60 && perc < 70)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (perc >= 50 && perc < 60)
            {
                Console.WriteLine("Your Grade is D");
            }
            else
            {
                Console.WriteLine("You are Failed!");
            }
            Console.ReadLine();
        }
    }
}
