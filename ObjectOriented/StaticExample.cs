using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ObjectOriented
{

    internal class StaticExample
    {
        public void run()
        {
            //var staticClass = new StaticClass(); // cannot create object/instance
            //Laptop1 laptop1 = new Laptop1();
            //Laptop1 laptop2 = new Laptop1(10);


            Student1 student1 = new Student1("Ramey", 3.4 , 101);
            Student1 student2 = new Student1("Hari", 3.5, 102);
            Student1 student3 = new Student1("Shamey", 3.6, 103);

            Console.WriteLine(Student1.TotalStudent);
            Student1.DisplaySchoolInfo();
            student2.DisplayInfo();

        }
    }

    public static class StaticClass
    {
        public static void test()
        {

        }
    }

    class Laptop1
    {
        public static string manufacturer;
        public int ramSize;

        public Laptop1()
        {
            manufacturer = "NITROV";
        }
        public Laptop1(int ramSize)
        {
            this.ramSize = ramSize;
            Console.WriteLine(manufacturer);
            Console.WriteLine(ramSize);
        }
    }




    class Student1
    {
        public static string SchoolName;
        public static int TotalStudent;
        public string Name;
        public int StudentId;
        public double GPA;

        static Student1()
        {
            SchoolName = "Neapthya College";
            TotalStudent = 0;
            Console.WriteLine("welcome to Nepathya College");
        }

        public Student1(string name, double gpa, int studentId )
        {
            Console.WriteLine($"Paramerized constructor called for student {name}");
            Name = name;
            StudentId = studentId;
            GPA = gpa;
            TotalStudent++;

        }

        public static void DisplaySchoolInfo()
        {
            Console.WriteLine($"College name {SchoolName}. Total No. of student {TotalStudent}.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name id {Name}. Id is {StudentId}. GPA is {GPA}. Total student is {TotalStudent}.");
        }
    }

    
    
}