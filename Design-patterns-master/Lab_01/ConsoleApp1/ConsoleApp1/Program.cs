namespace ConsoleApp1
{
    internal class Program
    {
        public interface I1
        {
            public int I1_property { get; set; }
            public void I1_method();
            public event EventHandler I1_event;
            public int this[int index] { get; set; }
        }
        public class C1
        {
            private const int pc1 = 2;
            public const int pc2 = 3;
            protected const int pc3 = 4;
            private int pi1 = 100;
            private string ps1 = "Nikita";
            public int pi2 = 200;
            public string ps2 = "Danila";
            protected int pi3 = 300;
            protected string ps3 = "Gosha";
            private int PrIn { get; set; }
            public int PubIn { get; set; }
            public string PubStr { get; set; }
            protected int ProtIn { get; set; }
            public C1()
            {
                Console.WriteLine("Конструктор по умолчанию");
            }
            public C1(C1 c)
            {
                Console.WriteLine("Конструктор копирования");
                PubIn = c.pi2;
                PubStr = c.ps2;
            }
            public C1(int pi2, string ps2)
            {
                Console.WriteLine("Конструктор с параметрами");
                this.pi2 = pi2;
                this.ps2 = ps2;
            }
            private void PrMethod()
            {
                Console.WriteLine("Вызвался приватный метод.");
            }
            public void PubMethod()
            {
                Console.WriteLine("Вызвался публичный метод.");
                PrMethod();
            }
            protected void ProtMethod()
            {
                Console.WriteLine("Вызвался защищенный метод.");
            }
        }
        public class C2 : C1, I1
        {
            public event EventHandler I1_event;
            public int I1_property { get; set; }

            public int this[int index] { get { return pi3; } set { pi3 = 200; } }

            public C2()
            {
                Console.WriteLine("Конструктор по умолчанию");
            }
            public C2(C2 c)
            {
                Console.WriteLine("Конструктор копирования");
                PubIn = c.pi2;
                PubStr = c.ps2;
            }
            public C2(int pi2, string ps2)
            {
                Console.WriteLine("Конструктор с параметрами");
                this.pi2 = pi2;
                this.ps2 = ps2;
            }

            public void I1_method()
            {
                Console.WriteLine("Метод интерфейса I1 в классе C2");
            }
        }

        public interface I2
        {
            public void I2_method();//{ Console.WriteLine("Метод в интерфейсе I2"); }
        }
        public class C3
        {
            public string public_string = "Публичная строка";
            private string private_string = "Приватная строка";
            public string Show_pr_string
            {
                get { return private_string; }
            }
            protected string protected_string = "Защищенная строка.";
            public void Method()
            {

            }
        }
        public class C4 : C3, I2
        {
            public string C4_string = "Строка в классе С4";

            public void I2_method() 
            {
                Console.WriteLine("Вызван метод интерфейса I2 в классе C4");
            }
        }
        static void Main(string[] args)
        {
            C1 first = new C1();
            C1 second = new C1(123, "ALE");
            C1 third = new C1(second);
            Console.WriteLine($"{first.pi2}\t {first.ps2}");
            Console.WriteLine($"{second.pi2}\t {second.ps2}");
            Console.WriteLine($"{third.PubIn}\t {third.PubStr}");
            first.PubMethod();

            C2 first_c2 = new C2();
            C2 second_c2 = new C2(123, "PRIVET");
            C2 third_c2 = new C2(second_c2);
            first_c2.I1_method();
            first_c2.I1_property = 123456;
            Console.WriteLine($"Свойство: {first_c2.I1_property} Поле: {first_c2.ps2}");

            C4 first_c4 = new();
            string pr_str = first_c4.Show_pr_string;
            first_c4.Method();
            Console.WriteLine($"Наследуем от C3 приватную строку {pr_str}");
        }
    }
}