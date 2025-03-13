namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Hyundai";
            car.Model = "Ioniq 5";
            car.Year = 2022;
            
            Console.WriteLine($"I drive a {car.Year} {car.Make} {car.Model}.");
        }
    }
}
