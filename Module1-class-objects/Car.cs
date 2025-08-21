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
        
        public  string Brand { get; set; }
        public  string Model { get; set; }
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
