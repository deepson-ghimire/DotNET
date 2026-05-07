using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class ConstructorExample
    {
        public void run() {
            Laptop laptop = new Laptop();
            var s = Laptop.manufracture;
        }
    }

    class Laptop
    {
        public static string manufracture;
        public int ramSize;
        public string modelName;
        public readonly int serialNumber;

        static Laptop()
        {
            Console.WriteLine("Static Constructor");
            manufracture = "NITROV";
        }

        public Laptop()
        {
            Console.WriteLine("Default Constructor");
            ramSize = 0;
            modelName = "unknown";
            serialNumber = 0;
        }

        public Laptop(int ramSize, string modelName, int serialNumber)
        {
            this.ramSize = ramSize; 
            this.modelName = modelName;
            this.serialNumber = serialNumber;
        }

        public Laptop(Laptop existingLaptop)
        {
            ramSize = existingLaptop.ramSize;
            modelName = existingLaptop.modelName;
        }

    }
}


