// See https://aka.ms/new-console-template for more information


using Module1_class_objects;
using System.Threading.Channels;


//Task 2: Create Objects of the Class
// Creating first car object: Toyota
// Prefered approach
Car Toyota = new Car
{
    Brand = "Toyota",
    Model = "Corolla",
    ManufacturingYear = 2025,
    Mileage = 50
};

// Access Drive method
Console.WriteLine($"Initial mileage of {Toyota.Brand} {Toyota.Model} is: {Toyota.Mileage} km");
Console.Write("Enter the mileage that your car drove: ");
int givenMileageForToyota = Convert.ToInt32(Console.ReadLine());
Toyota.Drive(givenMileageForToyota);
Console.WriteLine($"Total mileage of {Toyota.Brand} {Toyota.Model} is: {Toyota.Mileage} km");

//Task 3: Accessing ShowCarInfo method
Toyota.ShowCarInfo();


// Creating second car object: Tesla
// alternate approach

Car Tesla = new Car();

Tesla.Brand = "Tesla";
Tesla.Model = "Model 3";
Tesla.ManufacturingYear = 2025;
Tesla.Mileage = 120;

// Access Drive method
Console.WriteLine($"Car {Tesla.Brand} {Tesla.Model} has driven {Tesla.Mileage} km");
Console.Write("Enter the mileage that your car drove: ");
int givenMileageForTesla = Convert.ToInt32(Console.ReadLine());
Tesla.Drive(givenMileageForTesla);
Console.WriteLine($"Total mileage: {Tesla.Mileage}\n");


//Task 3: Accessing ShowCarInfo method
Tesla.ShowCarInfo();



