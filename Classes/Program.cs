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

            Console.WriteLine("Cars for sale!!");
            Console.WriteLine();
            Console.WriteLine(car1.Make + " " + car1.Model + " " + car1.Year);
            //Console.WriteLine(car1.Model);
            //Console.WriteLine(car1.Year);
            Console.WriteLine();
            Console.WriteLine(car2.Make + " " + car2.Model + " " + car2.Year);
            //Console.WriteLine(car2.Model);
            //Console.WriteLine(car2.Year);
        }
        
    }
}
