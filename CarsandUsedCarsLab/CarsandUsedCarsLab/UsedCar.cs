
namespace CarsandUsedCarsLab
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
        {
            Car car = new Car(make, model, year, price);
            this.Make = car.Make;
            this.Model = car.Model;
            this.Year = car.Year;
            this.Price = car.Price;
            this.Mileage = mileage;
        }

        public override string ToString()
        {
            return $"{this.Year} {this.Make} {this.Model} with {this.Mileage} miles : ${this.Price}";
        }
    }
}
