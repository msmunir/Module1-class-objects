using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_class_objects
{
    // Task 1: Create a Car Class
    public class Car
    {
        /* 
        I am coding the first property like this,
        Just for my own understanding and future reference.

        Note:
        Initialize property with default value. Why?
        Because, Newer version of C# has nullable reference types enable.
        So if not initialize Compiler will give warnings for nullable type.
        Non-nullable - Must always have a value.
        So,Initializing property with default value.
        */

        // First approach:
        // field/variable
        private string brand = string.Empty;


        // property 
        public string Brand                
        {
            // get method
            // return the value of the variable/field brand.
            get { return brand; }
            
            // set method
            // assign value to the variable/field brand.
            set { brand = value; }
        }


        /*
        Second approach: Make properties nullable

        Note: 
        "?" nullable reference type modifier
         Here The Model property can now hold either:
            i) A valid string value(e.g., "Toyota","Corolla")
            ii) null (no value)
        */
        public string? Model { get; set; }

        #region
        /*
        Second approach: Shorcart version of First approach
        public string Model { get; set; } = string.Empty;


        Fourth approach: Initializing with default value
        public string Model { get; set; } = "Unknown"; 

        Fifth approach: (c# 11+) by using "required" modifier
        public required string Model { get; set; }

        
        Sixth approach: Using Constructor 
        To ensure propertis are initialized

        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufacturingYear { get; set; }
        public int Mileage {  get; set; }
        public Car( string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        */
        #endregion



        public int ManufacturingYear { get; set; }
        public int Mileage {  get; set; }

        // Creating Drive method
       public void Drive( int kilometers)
        {
            
            // updating the mileage
            Mileage += kilometers;
            Console.WriteLine($"Car {Brand} {Model} driven {kilometers} km. Total mileage is now: {Mileage} km");
        }


        // Creating ShowCarinfo method
        public void ShowCarInfo()
        {
            Console.WriteLine($"\nCar info: Brand - {Brand}, Model - {Model}, Year - {ManufacturingYear}, Mileage - {Mileage} \n");
        }



    }
}
