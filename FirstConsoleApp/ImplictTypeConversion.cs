using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class ImplictTypeConversion
    {
        public void run()
        {

        }

        private void sameTypeExample()
        {
            byte a = 10;
            short b = a;
            int c = a;
            long d = a;
        }

        private void differentTypeExample()
        {
           

            int a = 10;
            float b = a;  //it is compitable

            // char <-> int  // it is compitable 

            char aa = 'A';
            int bb = aa;
            
        }

    }
}
