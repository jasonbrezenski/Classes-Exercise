namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dot.notation
            var vehicle = new Car();  
            vehicle.Make = "VW";
            vehicle.Model = "Atlas";
            vehicle.Year = 2022;
            
            Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }
}
