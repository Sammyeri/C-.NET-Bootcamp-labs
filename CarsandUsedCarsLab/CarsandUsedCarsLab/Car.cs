

using System.Runtime.CompilerServices;

namespace CarsandUsedCarsLab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = "Toyota";
            this.Model = "Camry";
            this.Year = 2000;
            this.Price = 35000;
        }

        public Car(string make, string model, int year, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public override string ToString()
        {
            return $" {this.Year} {this.Make} {this.Model}: ${this.Price}";
        }

        public static List<Car> cars = new List<Car>();

        public static void ListCars()
        {
            for(int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i}: {cars[i].Year} {cars[i].Make} {cars[i].Model}, ${cars[i].Price}" );
            }
        }

        public static void Remove(int index)
        {
            cars.Remove(cars[index]);
        }
    }
}
