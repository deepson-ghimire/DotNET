using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class ExplictConversion
    {
        public void run()
        {
            //example();
            //arithmeticOperation();
            int x = 40;
            //argumentByValue(out x);
            Console.WriteLine(x);

            charConversion();
        }

        void argumentByValue(out int a)
        {
            a = 10;
        }

        private void example()
        {
            double a = 10.5;
            int b = (int)a;

            //Console.WriteLine(b);

            long c = 345246535475;  // 345246535475 % 256
            byte d = (byte)c;
            //Console.WriteLine(d);

            char e = 'A';
            byte f = (byte)e;
            //Console.WriteLine(f);


            int g = Convert.ToInt32("123");
            //Console.WriteLine(g);
        }
        // Ask two number input from using console.Readline, TYpe cast them into numeric value and performm addition, subtraction, multiplication and division.
        private void arithmeticOperation()
        {
            //String a = Console.ReadLine();
            //String b = Console.ReadLine();  

            //int c = Convert.ToInt32(a);
            //int d = Convert.ToInt32(b);

            //int sum = c + d;
            //int sub = c - d;
            //int mul = c * d;
            //int div = c / d;

            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            //Console.WriteLine(mul);
            //Console.WriteLine(div);


            // Ask a floating number input form user using consloe.readline, TYpe cast  it into double first and then into byte;

            //String e = Console.ReadLine();

            //double f = Convert.ToDouble(e);
            //Console.WriteLine(f);

            //byte g = Convert.ToByte(f);
            //Console.WriteLine(g);


            // parse

            //var h = int.Parse("123dd");
            //Console.WriteLine(h);

            // tryparse
            int h;
            var resp = int.TryParse("130", out h);
            Console.WriteLine(resp);
            Console.WriteLine(h);


          

        }
        void charConversion()
        {
            // Ask a dingle cahr from user using console.Readline, TYpe Cast it into char first and then into int.

            string a = Console.ReadLine();
            char b;

            var resp = char .TryParse(a, out b);
            Console.WriteLine(resp);
            Console.WriteLine(b);

            int c = b;
            Console.WriteLine(c);

        }



    }
}
