using System.Security.Cryptography.X509Certificates;

namespace Lab_01
{
    internal class Program
    {
        interface IFoo
        {
            void Foo() { Console.WriteLine("Метод внутри интерфейса."); }
        }
        abstract class Human
        {
            public abstract string? Name { get; set; }
            public abstract int Age { get; set; }
            public abstract void Print();
        }
        class Man : Human, IFoo
        {
            public override string? Name { get; set; }
            public override int Age { set; get; }

            //public void Foo()
            //{
            //    Console.WriteLine("Метод в классе Man.");
            //}

            public override void Print()
            {
                Console.WriteLine($"Name: {Name} Age: {Age} Pol: M");
            }
        }
        class Woman : Human, IFoo
        {
            public override string? Name { get; set; }
            public override int Age { set; get; }
            public override void Print()
            {
                Console.WriteLine($"Name: {Name} Age: {Age} Pol: F");
            }
            public void Foo()
            {
                Console.WriteLine("Метод в классе Woman.");
            }
        }
        class Vehicle
        {
            public virtual void Go()
            {
                Console.WriteLine("Перемещаюсь.");
            }
            public void Print() { Console.WriteLine("Метод Print в классе Vehicle"); }
        }
        class Car : Vehicle
        {
            private int TEST;
            public int Price { private get; set; }
            public string? Name { get; set; }
            public int Probeg { get; set; }

            public void Get_Price()
            {
                Console.WriteLine(Price);
            }

            public void Test(int x)
            {
                TEST = x;
                Console.WriteLine(TEST);
            }

            public override void Go()
            {
                Console.WriteLine("Еду на машине.");
            }
            public new void Print() { Console.WriteLine("Метод Print в классе Car"); }
            public void Print(Car car)
            {
                Console.WriteLine($"Машина {car.Name} едет. Пробег {car.Probeg}");
            }
            public void Print(Car car1, Car car2)
            {
                Console.WriteLine($"Машина {car1.Name} и {car2.Name} едет. Общий пробег: {car1.Probeg + car2.Probeg}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Man man = new Man();
            man.Name = "Nikita"; man.Age = 19; man.Print();
            ((IFoo)(man)).Foo();
            IFoo foo = new Man();
            foo.Foo();
            Woman woman = new Woman();
            woman.Name = "Dasha"; woman.Age = 18; woman.Print();
            woman.Foo();
            Vehicle vehicle = new Vehicle();
            vehicle.Print();
            Car car1 = new Car();
            Car car2 = new Car();
            car1.Name = "БМВ"; car1.Probeg = 1000;
            car2.Name = "Рено"; car2.Probeg = 2000;

            car1.Print(car1);
            car1.Print(car1, car2);

            car1.Price = 2000000;
            //Console.WriteLine(car1.Price);
            car1.Test(2);
        }
    }
}