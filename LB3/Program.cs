using System;

namespace l3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            

            Car car = new Car("Subaru Forester", 2007, "grey", "grey");
            Engine engine = new Engine(false, "Thermal engines", "Thermal engines");
            Wheels wheels = new Wheels(10,10, "Steel Wheels");

            Console.WriteLine(car.ToString());
            Console.WriteLine(car.Equals(""));
            Console.WriteLine(car.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(wheels.ToString());
            Console.WriteLine(wheels.Equals(""));
            Console.WriteLine(wheels.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(engine.ToString());
            Console.WriteLine(engine.Equals(""));
            Console.WriteLine(engine.GetHashCode());
            //Console.WriteLine($"Модель автомобіля-:{car.model};");
            Console.WriteLine();
            Console.WriteLine("Замінити колеса - 1; Перевірка пального -2; Запуск двигуна -3 Зупинити машину-4");
            bool breake = false;
            do
            {
                switch (Console.ReadLine()) 
                {
                    case "1": wheels.setWheel(); break;
                    case "2": engine.refuel(); break;
                    case "3": engine.ON(); break;
                    case "4": engine.STOP(); break;
                    default: Console.WriteLine(""); break;


                }
            } while (!breake);



        }
        public class Car
        {
            public string Fcolor;     //Factory color
            public string color;
            public int year;
            public string model;
            public Car(string model, int year, string color, string Fcolor)
            {

                this.model = model;
                this.year = year;
                this.color = color;
                this.Fcolor = Fcolor;
            }

            public override string ToString()
            {
                return this.model + " " + this.year + " " + this.color;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (this.color == this.Fcolor)
                {
                    return true;
                }
                else
                    return false;
                        
            }

            public override int GetHashCode()
            {
                if (color == Fcolor)
                {
                    return 50;
                }
                else
                    return 100;
            }

        }
        public class Wheels
        {
            
            public int Fdiam;    //Factory diam
            public int diam;
            public string Twheels; //Type of wheels
            public Wheels(int diam, int Fdiam, string Twheels)
            {

                this.diam = diam;
                this.Fdiam = Fdiam;
                this.Twheels = Twheels;

            }
            int newDiam;
            
            public virtual void setWheel()
            {
                
                Console.WriteLine("Запишіть діаметр...");
                newDiam = Convert.ToInt32(Console.ReadLine());
                if (newDiam < 13)
                {
                    this.newDiam = 13;

                    Console.WriteLine("Мінімальний діаметр 13");
                }
                
                if (newDiam > 29)
                {
                    this.newDiam = 29;
                    Console.WriteLine("Максимальний діаметр 29");
                }
                ChangeWheel();
            }
            public void ChangeWheel()
            {

                Console.WriteLine("Заміна колес...");
                Console.WriteLine($"Колесо замінено:{newDiam }");
            }

            public override string ToString()
            {
                return this.diam + " " + this.Fdiam + " " + this.Twheels;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (this.Fdiam == this.diam)
                {
                    return true;
                }
                else
                    return false;

            }

            public override int GetHashCode()
            {
                if (diam == Fdiam)
                {
                    return 50;
                }
                else
                    return 100;
            }

        }
        public class Engine
        {
            public string Fentype; // Factory engine type
            public string Entype; //engine type
            bool fuel;
            bool isWorking;
            public Engine(bool fuel, string Entype, string Fentype)
            {
                this.fuel = fuel;
                this.Entype = Entype;
                this.Fentype = Fentype;
            }

            public void refuel()
            {
                if (fuel == false)
                {
                    Console.WriteLine("Машина не заправленна");

                    Console.WriteLine("Заправляю...");
                    fuel = true;
                    Console.WriteLine("Заправлено!");
                }
                else
                {
                    Console.WriteLine("Заправлено!");
                }
            }
            public void ON()
            {

                Console.WriteLine("Запуск двигуна...");
                if (!fuel)
                {

                    Console.WriteLine("Машина не заправлена");
                    isWorking = false;

                }
                else
                {
                    Console.WriteLine("Машина поїхала");
                    isWorking = true;
                }
            }

            public void STOP()
            {

                if (isWorking == true)
                {
                    Console.WriteLine("Машину зупинено");
                }
                else
                {
                    Console.WriteLine("Машина не була заведена");
                }
            }


            public override string ToString()
            {
                return this.fuel + " " + this.Fentype + " " + this.Entype;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (this.Entype == this.Fentype)
                {
                    return true;
                }
                else
                    return false;

            }

            public override int GetHashCode()
            {
                if (Fentype == Entype)
                {
                    return 50;
                }
                else
                    return 100;
            }

        }

    }
}
