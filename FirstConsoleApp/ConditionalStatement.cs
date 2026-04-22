using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class ConditionalStatement
    {
        public void run() { 
            iterationExample();
        }

        private void iterationExample()
        {
            // before execution
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine($"Iteration {i}");
            }
            //foreach
            //string arr[] = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


            // Write a program that generates the multiplication table f a bumber provided by the user using a while or for looop. for example if the user enters 5, the program should display the multiplication table form 5*1 to 5  10

            //string num = Console.ReadLine();
            //int a;
            //int.TryParse(num, out a);
            //for (int i = 1; i <= 10; i++)
            //{

            //    if(i == 3)
            //        continue;

            //    if (i == 6)
            //        break;
            //    Console.WriteLine(i);

            //    //Console.WriteLine($"{a} X {i}= {a*i} ");
            //}

            // Sum of Number
            string num = Console.ReadLine();
            int a;
            int sum = 0;
            int.TryParse(num, out a);
            for (int i = 1; i <= a; i++)
            {

                if (i == 5)
                    continue;

                if (i == a)
                    break;

                sum += i;
            }
                Console.WriteLine(sum);
        }

    }
}
