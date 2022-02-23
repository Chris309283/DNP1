using S2_Ex5;

var car1 = new Car(1.0, 30, false, "Pink");
var car2 = new Car(1.3, 25, true, "Pink");
var car3 = new Car(1.8, 23, true, "White");
var car4 = new Car(2.0, 20, true, "Blue");
var car5 = new Car(3.0, 16, false, "Silver");

List<Car> cars = new List<Car>
{
    car1,
    car2,
    car3,
    car4,
    car5
};

void GetCarsByColor(string color)
{
    foreach (var car in cars.FindAll(car => car.Color.Equals(color)))
    {
        Console.WriteLine(car.ToString());
    }
}

void GetCarsByColors(string[] colors)
{
    foreach (var color in colors)
    {
        foreach (var car in cars.FindAll(car => car.Color.Equals(color)))
        {
            Console.WriteLine(car.ToString());
        }
    }
}

void GetCarsByEngineBigger(double engineSize)
{
    foreach (var car in cars.FindAll(car => car.EngineSize > engineSize))
    {
        Console.WriteLine(car.ToString());
    }
}

void GetCarsByEngineBetween(double engineSizeBigger,double engineSizeSmaller)
{
    foreach (var car in cars.FindAll(car => car.EngineSize > engineSizeBigger && car.EngineSize < engineSizeSmaller))
    {
        Console.WriteLine(car.ToString());
    }
}

void GetCarsWithFuelEconomyLower(double fuelEconomy)
{
    foreach (var car in cars.FindAll(car => car.FuelEconomy < fuelEconomy))
    {
        Console.WriteLine(car.ToString());
    }
}

GetCarsByColor("Pink");

Console.WriteLine("-----");

GetCarsByColors(new string[] {"Pink", "Blue"});

Console.WriteLine("-----");

GetCarsByEngineBigger(1.3);

Console.WriteLine("-----");

GetCarsByEngineBetween(1.3,3.0);

Console.WriteLine("-----");

GetCarsWithFuelEconomyLower(23);