using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace FirstConsoleApp
{
    struct User
    {
        public int Id;
        public string Firstname;
        public string Lastname;

        // Method must be inside struct
        public string getFullName()
        {
            return Firstname + " " + Lastname;
        }
    }

    struct Point1
    {
        public int X;
        public char Label;
    }
    struct Point2
    {
        public int X;
        public string Name;
    }

    struct point3
    {
        public int X;
        public NameInfo Name;
    }

    class NameInfo
    {
        public string Value;
    }

    internal class StructExample
    {
        public void Run()
        {
            //Userexample();
            point1Example();
            point2Example();
        }



        private void point1Example()
        {
            Point1 p1 = new Point1();
            p1.X = 10;
            p1.Label = 'A';

            Point1 p2 = p1;
            p2.X = 20;
            p2.Label = 'B';

            Console.WriteLine($"P1 x={p1.X} Label= {p1.Label}");
            Console.WriteLine($"P2 x={p2.X} Label= {p2.Label}");
        }
        private void point2Example()
        {
            Point2 p1 = new Point2();
            p1.X = 10;
            p1.Name = "hari";

            Point2 p2 = p1;
            //p2.X = 20;
            //p2.Name = "samman";
            Console.WriteLine($"P1 x= {p1.X} Name={p1.Name}");
            //Console.WriteLine($"P2 x={p2.X} Name= {p2.Name}");


        }

        private void point3Example()
        {

        }

        private void Userexample()
        {
            User user2 = new User();

            user2.Firstname = "Ramey";  
            user2.Lastname = "Yadhav";

            var fullName = user2.getFullName();

            Console.WriteLine(fullName);
        }
    }
}