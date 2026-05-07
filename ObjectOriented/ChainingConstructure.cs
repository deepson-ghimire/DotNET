using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class ChainingConstructure
    {
        public void run()
        {
            Student student = new Student("Ramey");
            Console.WriteLine(student.Grade);
            Console.WriteLine(student.Name);

            Student student1 = new Student("Rameey", 4.5);
            Console.WriteLine(student1.Grade);
            Console.WriteLine(student1.Name);
        }
    }

    class Student
    {
        public string Name;
        public double Grade;

        // COnstructure 1
        public Student(string name, double grade) {
            this.Name = name;
            this.Grade = grade;
        }


        // Constructure 2 chaning 
        public Student(string name) : this(name,0){
        }
    }


}
