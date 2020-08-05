using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    class VehicleApp
    {
        static void Main()
        {
        
                Vehicle car = new Vehicle("Cielo", "red");
                car.Start();
                car.Stop();

                Console.WriteLine("------------------------------------------------------------------------");

                Vehicle truck = new Vehicle(VehType.Truck, FuelType.Diesel, "Tata", "blue", 6, "birla");
                truck.Start();
                truck.Stop();

                Console.WriteLine("---------------------------------------------------------------------------");

                Vehicle smallcar = new Vehicle("Indica", "silver", VehType.Car, 4);
                smallcar.Start();
                smallcar.Stop();

                Console.Read();
            }
        }
    }


