using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.User
{
    internal class UserInfo
    {
        public  void showProfile(string name, int age)
        {
            Console.WriteLine($"Name is {name}. Age is {age}")
        }
    }
}
