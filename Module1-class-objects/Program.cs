// See https://aka.ms/new-console-template for more information


using Module1_class_objects;


//Task 2: Create Objects of the Class
// Creating first car object: Toyota
// Prefered approach
Car myToyota = new Car
{
    Brand = "Toyota",
    Model = "Corolla",
    ManufacturingYear = 2025,
    Mileage = 50
};

// Access Drive method
Console.WriteLine($"Initial mileage of {myToyota.Brand} {myToyota.Model} is: {myToyota.Mileage} km");
myToyota.Drive(30);
Console.WriteLine($"Total mileage of {myToyota.Brand} {myToyota.Model} is: {myToyota.Mileage} km");

//Task 3: Accessing ShowCarInfo method
myToyota.ShowCarInfo();


// Creating second car object: Tesla
// alternate approach

Car myTesla = new Car();

myTesla.Brand = "Tesla";
myTesla.Model = "Model 3";
myTesla.ManufacturingYear = 2025;
myTesla.Mileage = 120;

// Access Drive method
Console.WriteLine($"Car {myTesla.Brand} {myTesla.Model} has driven {myTesla.Mileage} km");
myTesla.Drive(30);
Console.WriteLine($"Total mileage: {myTesla.Mileage}\n");


//Task 3: Accessing ShowCarInfo method
myTesla.ShowCarInfo();



