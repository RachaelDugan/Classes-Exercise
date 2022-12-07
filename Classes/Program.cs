namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda", "Miata", 2011);
            Car car2 = new Car("Ford", "F150", 2019);


            //car1.Model = "Ford";
            //car2.Model = "Mazda";

            //car1.Make = "F150";
            //car2.Make = "Miata";

            //car1.Year = 2019;
            //car2.Year = 2011;

            Console.WriteLine("These are cars.");
            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);
            Console.WriteLine();
            Console.WriteLine(car2.Make);
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.Year);
        }
        
    }
}
