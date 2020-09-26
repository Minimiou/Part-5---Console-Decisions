using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Stages()
        {
            Console.WriteLine("Stages\n");
            string age;
            int number;

            Console.WriteLine("Enter your age:");
            age = Console.ReadLine();

            if (Int32.TryParse(age, out number))
            {
                if (number > 18)
                {
                    Console.WriteLine("You are an adult\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("This is not a valid age!\n");
                }
                else if (number <= 5)
                {
                    Console.WriteLine("You are a toddler\n");
                }
                else if (number <= 10)
                {
                    Console.WriteLine("You are a Child\n");
                }
                else if (number <= 12)
                {
                    Console.WriteLine("You are a preteen\n");
                }
                else if (number > 12)
                {
                    Console.WriteLine("You are a teen\n");
                }
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("This is not a number\n");
                Console.ReadLine();
            } 
        }
        static void Hurricane()
        {
            Console.WriteLine("Hurricane\n");
            string category;
            int number;

            Console.WriteLine("Enter the category of the hurricane (1 to 5):");

            category = Console.ReadLine();

            if (Int32.TryParse(category, out number))
            {
                if (number > 5)
                {
                    Console.WriteLine("That isin't a valid number.\n");
                }
                else
                {
                    Console.WriteLine("The wind speeds are:");
                }
                switch (number)
                {
                    case 1 :
                        Console.WriteLine("74-95 mph, 64-82 kt, 119-153 km/hr\n");
                         break;
                    case 2:
                        Console.WriteLine("96-110 mph, 83-95 kt, 154-177 km/hr\n");
                        break;
                    case 3:
                        Console.WriteLine("111-130 mph, 96-113 kt, 178-209 km/hr\n");
                        break;
                    case 4:
                        Console.WriteLine("135-155 mph, 114-135 kt, 210-249 km/hr\n");
                        break;
                    case 5:
                    Console.WriteLine("Greater than 155 mph, or 135 kt, or 249 km/hr\n");
                    break;
                }
            }
            else
            {
                Console.WriteLine("That isin't a valid number.\n");
            }
            Console.ReadLine();
        }
        static void RandomDivisible()
        {
            int rando;
            string input;
            int number;
            int answer;

            Random num = new Random();
            rando = num.Next(2,7);
            Console.WriteLine($"Write a number bigger than {rando}:");
            input = Console.ReadLine();

            if (Int32.TryParse(input, out number))
            {
                if (number % rando == 0)
                {
                    Console.WriteLine("Divisible");
                }
                else if (number < rando)
                {
                    Console.WriteLine("The number entered is smaller than the computer's.");
                }
                else if (number % rando != 0)
                {
                    Console.WriteLine("Non divisible");
                }
            }
            else
            {
                Console.WriteLine("This is not a valid number");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Stages();
            Hurricane();
            RandomDivisible();
        }
    }
}
