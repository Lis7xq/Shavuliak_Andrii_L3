using System;
using System.Collections.Generic;
using System.Text;

namespace LB3_2
{
    public abstract class Toy
    {
        public abstract string ClassName { get; set; }
        public abstract string Property { get; set; }
        public int price;
        public int Age;
        public override string ToString()
        {
            return (String.Format("{0} {1} {2}", price, Property, ClassName));
        }
        
    }

    public abstract class Ball : Toy
    {
        public string color;
        
    }

    public class SmallBall : Ball
    {
        public SmallBall(int price, string color, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.color = color;
        }

        public override string ClassName { get => "Small Ball"; set => ClassName = value; }
        public override string Property { get => color; set => color = value; }
    }

    public class BigBall : Ball
    {
        public BigBall(int price, string color, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.color = color;
        }

        public override string ClassName { get => "Big Ball"; set => ClassName = value; }
        public override string Property { get => color; set => color = value; }
    }


    public abstract class Car : Toy
    {
        public string type;
    }

    public class SmallCar : Car
    {
        public SmallCar(int price, string type, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.type = type;
        }

        public override string ClassName { get => "Small Car"; set => ClassName = value; }
        public override string Property { get => type; set => type = value; }
    }

    public class MediumCar : Car
    {
        public MediumCar(int price, string type, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.type = type;
        }

        public override string ClassName { get => "Medium Car"; set => ClassName = value; }
        public override string Property { get => type; set => type = value; }
    }

    public class BigCar : Car
    {
        public BigCar(int price, string type, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.type = type;
        }

        public override string ClassName { get => "Big Car"; set => ClassName = value; }
        public override string Property { get => type; set => type = value; }
    }

    public class Cube : Toy
    {
        private string Material;
        public Cube(int price, string Material, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.Material = Material;
        }

        public override string ClassName { get => "Cube"; set => ClassName = value; }
        public override string Property { get => Material; set => Material = value; }
    }

    public class Doll : Toy
    {
        public Doll(int price, string name, int Age)
        {
            this.Age = Age;
            this.price = price;
            this.name = name;
        }
        private string name;
        public override string ClassName { get => "Doll"; set => ClassName = value; }
        public override string Property { get => name; set => name = value; }
    }
}
