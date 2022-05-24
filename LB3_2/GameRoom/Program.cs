using System;

namespace LB3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter budget");
            int TotalPrice = Convert.ToInt32(Console.ReadLine());

            if (TotalPrice < 50)
            {
                TotalPrice = 50;
                Console.WriteLine("Minimum budget $50");
            }

            if (TotalPrice > 2000)
            {
                TotalPrice = 2000;
                Console.WriteLine("Maximum budget $2000");
            }
            Console.WriteLine("AGE CATEGORIES");
            Console.WriteLine("Small kids categories 3-6///Medium kids categories 6-10/// Big kids categories 10-12");
            Console.WriteLine("enter the average age of the children");
            int Age = Convert.ToInt32(Console.ReadLine());
            
            if(Age < 3)
            {
                Age = 3;
                Console.WriteLine("Minimum age is 1");
            }
            if(Age > 12)
            {
                Age = 12;
                Console.WriteLine("Max age is 13");
            }

            Room room = new Room();
            Console.WriteLine("Price/Property/Type");
            foreach (var n in room.FillRoom(TotalPrice, Age))
                Console.WriteLine(n);

            Console.WriteLine("Sort by price, press spacebar to continue");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine();
                Console.WriteLine("Price/Property/Type");
                room.SortByPrice(room.FillRoom(TotalPrice, Age));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the price of a toy to search for it");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter property");
            string Property = Console.ReadLine();
            Console.WriteLine();
            room.FindToyInRoom(Price, Property, room.FillRoom(TotalPrice, Age));
        }
    }
}
