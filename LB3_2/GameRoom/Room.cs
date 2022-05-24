using System;
using System.Collections.Generic;
using System.Linq;

namespace LB3_2
{
    class Room
    {
        

        public void SortByPrice(List<Toy> AllToys)
        {
            var PriceAscending = from p in AllToys
            orderby p.price
            select p;
            foreach (var n in PriceAscending)
                Console.WriteLine( n + "\n");
        }

        public List<Toy> GetToyList()
        {
            List<Toy> Toys = new List<Toy>();
            Toys.Add(new SmallBall(25, "Green", 3));
            Toys.Add(new SmallCar(50, "BMW", 3));
            Toys.Add(new Cube(150, "Plastic", 10));
            Toys.Add(new Doll(50, "Barbie", 6));
            Toys.Add(new BigCar(70, "Truck", 3));
            Toys.Add(new BigBall(20, "Blue", 12));
            Toys.Add(new Doll(40, "DXD", 6));
            Toys.Add(new Cube(120, "Plastic", 10));
            Toys.Add(new MediumCar(60, "MAN", 6));
            Toys.Add(new Doll(50, "Dora", 6));
            Toys.Add(new Cube(90, "Wooden", 10));
            Toys.Add(new Cube(170, "Lego", 12));
            Toys.Add(new Doll(30, "Masha", 3));
            Toys.Add(new SmallBall(30, "Red", 3));
            Toys.Add(new SmallBall(50, "Rainbow-colored", 3));
            Toys.Add(new BigCar(100, "garbage truck", 10));
            Toys.Add(new SmallBall(20, "light green", 3));
            Toys.Add(new Doll(60, "Natasha", 3));
            Toys.Add(new Cube(200, "Magnet", 12));
            Toys.Add(new Doll(50, "Bratz", 6));
            Toys.Add(new MediumCar(60, "crane", 6));
            Toys.Add(new BigBall(25, "Yellow", 10));
            Toys.Add(new SmallCar(200, "Radio-controlled", 3));
            Toys.Add(new SmallBall(20, "Dribling", 10));
            Toys.Add(new BigBall(20, "Dribling", 8));
            return Toys;
        }

        public List<Toy> FillRoom(int TotalPrice, int Age)
        {
            Room room = new Room();
            List<Toy> ToyList = room.GetToyList();
            List<Toy> AddedToys = new List<Toy>();
            int CurrentPrice = 0;
            if (TotalPrice > ToyList[0].price)
            {
                CurrentPrice = ToyList[0].price;
                AddedToys.Add(ToyList[0]);
            }
            
            foreach (var n in ToyList.Skip(1))
            {
                if (n.Age <= Age)
                {
                    AddedToys.Add(n);
                    CurrentPrice = CurrentPrice + AddedToys[AddedToys.Count - 1].price;
                }

                if (CurrentPrice > TotalPrice)
                {
                    CurrentPrice = CurrentPrice - AddedToys[AddedToys.Count - 1].price;
                    AddedToys.Remove(AddedToys[AddedToys.Count - 1]);
                }
            }
            return AddedToys;
        }

        public void FindToyInRoom(int Price, string Property, List<Toy> Toys)
        {
            bool IsFound = false;
            foreach (var n in Toys)
            {
                if (Price == n.price && Property == n.Property)
                {
                    Console.WriteLine("toy found");
                    IsFound = true;
                }
            }
            if (IsFound == false)
                Console.WriteLine("toy not found");
        }

    }
}
