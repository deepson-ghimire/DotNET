using System;

namespace ObjectOriented
{
    internal class ThisExample
    {
        public void run()
        {
            var person1 = new Person1();
            person1.SetName("Ramey");
            person1.setPerson();

            Console.WriteLine(User.name);

            User user = new User(); 
            Console.WriteLine(User.name);
        }
    }

    class User
    {
        public static string name;

        public static void setPerson(Person1 person1)
        {
            name = person1.GetName();  
        }
    }

    class Person1
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name; 
        }

        public string GetName()   
        {
            return name;
        }

        public void setPerson()
        {
            User.setPerson(this); 
        }
    }
}