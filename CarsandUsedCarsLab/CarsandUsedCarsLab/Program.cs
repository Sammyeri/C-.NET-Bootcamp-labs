
using CarsandUsedCarsLab;
using System.Diagnostics.CodeAnalysis;

Car car1 = new Car();
Car car2 = new Car("Chevy", "Silverado", 2018, 25000);
Car car3 = new Car("Honda", "Civic", 2020, 15000);
UsedCar car4 = new UsedCar("Ford", "F150", 2011, 2600, 10000);
UsedCar car5 = new UsedCar("Honda", "CRV", 2023, 10000, 200);
UsedCar car6 = new UsedCar("Ford", "F250", 2010, 2300, 2);

Car.cars.Add(car1);
Car.cars.Add(car2);
Car.cars.Add(car3);
Car.cars.Add(car4);
Car.cars.Add(car5);
Car.cars.Add(car6);


bool purchasing = true;
while (purchasing)
{
    Car.ListCars(); 
    Console.WriteLine("What car would you like to buy? (enter the number)");
    string userInputRaw = Console.ReadLine();

    bool succeded =int.TryParse(userInputRaw, out int userinput);

    if (succeded && userinput >= 0 && userinput < Car.cars.Count())
    {
        Car car = Car.cars[userinput];
        if(car.GetType() == typeof(Car))
        {
            Console.WriteLine($"Car {userinput} is the {car.Year} {car.Make} {car.Model} for {car.Price}");
        }
        else
        {
            UsedCar usedcar = (UsedCar)car;
            Console.WriteLine($"Car {userinput} is the {usedcar.Year} {usedcar.Make} {usedcar.Model} with {usedcar.Mileage} miles for {car.Price}");
        }
        Car.Remove(userinput);
        
    }
    else
    {
        Console.WriteLine($"Sorry, {userInputRaw} is not a valid index");
    }

    while (true)
    {
        Console.WriteLine("Would you like to shop some more (y/n)?");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if(Char.ToLower(choice.KeyChar) == 'y')
        {
            break;
        }
        else if (Char.ToLower(choice.KeyChar) == 'n')
        {
            Console.WriteLine("Goodbye!");
            purchasing = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid option.");
        }
    }

}