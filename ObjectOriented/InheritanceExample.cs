using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class InheritanceExample
    {
        public void run() { 

            ElectricCar car = new ElectricCar("BYD");
        
            car.start();



            PetrolCar petrolCar = new PetrolCar("CREATA");
            petrolCar.start();
            petrolCar.FillPetrol();


        }
    }

    class Vehicle
    {
        protected string name;


        public Vehicle(string name)
        {
            this.name = name;
        }
        public void start()
        {
            Console.WriteLine("Vehicle Started");
        }

    
    }

    class ElectricCar : Vehicle
    {
        public ElectricCar(string name): base(name)
        {

        }
        public string Name
        {
            get { return base.name; }
        }
        public void Drive() {
            Console.WriteLine("Electric vehicle is drived");
        }
        public void Charge() {
            Console.WriteLine("Electric car is charged");
        }
    }

    class PetrolCar : Vehicle {

        public PetrolCar(string name): base(name)
        {

        }
        public string Name
        {
            get {return base.name; }
        }
        public void FillPetrol()
        {
            Console.WriteLine("Petrol is filled");
        }
        public void Drive() {
            Console.WriteLine("Petrol car is ready to drive");
        }
    }

    class Bike : Vehicle {

        public Bike(string name) : base(name)
        {

        }
        public string Name
        {
            get { return base.name; }
        }
        public void Ride()
        {
            Console.WriteLine("Bike is ready to ride");
        }
    }

    class Truck : Vehicle {
        public Truck(string name) : base(name)
        {

        }
        public string Name
        {
            get { return base.name; }
        }
        public void LoadGoods()
        {
            Console.WriteLine("Goods is loaded");
        }
    }

}
