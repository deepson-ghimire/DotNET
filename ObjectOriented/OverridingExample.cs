using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class OverridingExample
    {
        public void run() {
            //ElectricCars car = new ElectricCars();   //ElectricCars mthod called

            Vehicles car = new ElectricCars();         // Vehicle method called
            car.start();
        }
    }

    class Vehicles
    {
        public string name;


       
        public virtual void start()
        {
            Console.WriteLine("Vehicle Started");
        }


    }

    class ElectricCars : Vehicles
    {
        //ovveride -> override
        
        public override void start()
        {
            Console.WriteLine("Electric car started");
        }

        //Method hiding -> new
        //public new void start()
        //{
        //    Console.WriteLine("Electric car started");
        //}
        public void Drive()
        {
            Console.WriteLine("Electric vehicle is drived");
        }
        public void Charge()
        {
            Console.WriteLine("Electric car is charged");
        }
    }
}
