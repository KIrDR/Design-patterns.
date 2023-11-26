

namespace laba01
{
    class Program
    {
        public static void Main()
        {

            Car volvo = new Car();

            volvo.name = "Karina";
            volvo.Power = 100; 


            volvo.Info();
            volvo.Ride();
            volvo.Upgrete((float)45.5);
            volvo.Info();

            SuperCar bentli = new SuperCar();
            bentli.name = "PAvel";
            bentli.Power = 1000;
            bentli.Info();
            bentli.Upgrete((float)124.55);
            bentli.Info();
            bentli.Ride();

            Console.WriteLine("\nEND! \n");
        }
    }
}