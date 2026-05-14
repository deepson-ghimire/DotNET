using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class AbstractExample
    {
        public void run() {
            Animal dog = new Dog();
            dog.MakeSound();
        }
    }
    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Eat() => Console.WriteLine("Animal Eating");
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Making sound");
        }
    }

    // Class problem
    public abstract class StudentBase
    {
        public abstract string Name { get; set; }

        public abstract void DisplayInfo();

        public abstract string this[int index] { get; set; }
    }

    class Student2 : StudentBase {
        private string name;
        private string[] courses = new string[5];
        public override string Name {
            get { return this.name; }
            set { name = value; }
        }

        public override void DisplayInfo() { 
            
        }
    }
}
