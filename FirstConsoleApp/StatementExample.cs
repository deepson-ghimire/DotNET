using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class StatementExample
    {
        public void run()
        {
            //largestNum();
            switchExample();
        }

        private void example()
        {
            int a = 10;
            int b = 20 + a;

            //Expression -> boolean
            if (true) { }
            else if (true) { }
            else { }
        }

        void largestNum()
        {
            //string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();
            //string num3 = Console.ReadLine();

            //int a, b, c;

            //int.TryParse(num1, out a);
            //int.TryParse(num2, out b);
            //int.TryParse(num3, out c);

            //int largest;

            //if (a > b && a > c)
            //{
            //    largest = a;

            //}
            //else if (b > c && b > a)
            //{
            //    largest = b;
            //}
            //else
            //{
            //    largest = c;
            //}

            //Console.WriteLine(largest);


            // if the user enters non numeric input prompt them again until they provide a valid number

            int number;
            Boolean isValid = false;

            while (!isValid)
            {
               string input = Console.ReadLine();

                isValid = int.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid");

                }

                Console.WriteLine(number);

            }


         
        }

        void switchExample()
        {
            Console.WriteLine("Enter number between 1 to 7: ");
            string a = Console.ReadLine();
            int day;
            int.TryParse(a, out day);

            switch (day)
            { 
                case 1:
                    Console.Write("Sunday"); break;

                case 2:
                    Console.Write("Monday"); break;

                case 3:
                    Console.Write("Tuesday"); break;

                case 4:
                    Console.Write("Wednesday"); break;

                case 5:
                    Console.Write("Thursday"); break;

                case 6:
                    Console.Write("Friday"); break;

                case 7:
                    Console.Write("Saturday"); break;

                default:
                    Console.Write("Invalid"); break;
            }



        }

    }
}
