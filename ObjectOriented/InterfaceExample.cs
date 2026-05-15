using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    // Interface
    // no implenentation
    // no access modifier

    internal class InterfaceExample
    {
        public void run()
        {
            Cat1 cat = new Cat1();
            cat.Name = "Test";
            cat.HaveMilk();
            cat.Eat();

            Student3 student = new Student3();
            student.name = "Test";
            student.age = 1;
            student.DisplayInfo();
            student.Study();
        }
    }

    public interface IAnimal
    {
        string Name {  get; set; }
        void Eat();
    }
    public interface IMammal
    {
        void HaveMilk();
    }

    public class Cat1 : IAnimal, IMammal { 
        public void HaveMilk() {
            Console.WriteLine("They gave milk");
        }

        public void Eat() {
            Console.WriteLine("Eatingg");
        }
        public string Name { get; set; }
    }


    // Class Task 

    public interface IStudent
    {
        string name { get; set; }
        int age { get; set; }

        void DisplayInfo();
        void Study();
    }

    public class Student3 : IStudent { 
        public string name { get; set; }
        public int age { get; set; }

        public void DisplayInfo() {
            Console.WriteLine($"Student Name is  { name} Age is {age}" );
        }
        public void Study() {
            Console.WriteLine("");
        }

    }
}
