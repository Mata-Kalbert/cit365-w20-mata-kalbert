using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kalbert";

            string location = "Utah";

            var date = DateTime.Now;

            var daysTil = DateTime.Parse("12-25-2020");

            var Christmas = daysTil - date;

            Console.WriteLine($"This is my first time programing in Csharp name is: {name} ");

            Console.WriteLine($"I have been living in {location} for the past fourteen years.");

            Console.WriteLine($"this is the current date: {date:MM-dd-yyyy}");

            Console.WriteLine($"Days until Christmas: {Christmas.ToString("dd")}");

          

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("please enter width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("please enter hight:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadLine();

        }
    }
}



