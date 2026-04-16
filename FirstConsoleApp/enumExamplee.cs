using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class enumExamplee
    {
        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        public void run()
        { 
            enumExamples();
        }
        public void enumExamples()
        {

            Day today = Day.Monday;
            Console.WriteLine("Today is: " + today);

        }
    }
}
