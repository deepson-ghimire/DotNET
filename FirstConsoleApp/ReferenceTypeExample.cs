using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class ReferenceTypeExample
    {
        public void run()
        {
            objectExample();
            dynamicExample();

        }
        private void objectExample()
        {
            object x = "Hello";
            //Console.WriteLine(((string)x).Length);
        }


        private void dynamicExample()
        {
            dynamic x = "Ramey";
            //Console.WriteLine(x.Length);
            x = 10;
            //Console.WriteLine(x + 20);
            x = 'A';
            //Console.WriteLine(++x);
        }
    }
}
