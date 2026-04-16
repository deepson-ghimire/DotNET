using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ReadKey();

            //Console.Write("Enter your first name: ");
            //var firstName = Console.ReadLine();
            //Console.Write("Enter your last name: ");
            //var lastName = Console.ReadLine();

            // Data Type
            // Value Type & Reference
            // Predefined & userDefine

            //Intergaral/ int Tye [whole number]
            // byte  [1 byte] [8 bit] = 2^8
            // short [2 byte] [8 bit] = 2^16
            // int   [4 byte] [8 bit] = 2^64
            // long  [8 byte] [8 bit] = 2^128

            //byte byteName = 255;
            //short shortName = 32767;
            //int intName = 281201821;
            //long longName = 654611546567651;

            //// Floating Data Type (fractional)

            //float fName = 0.6468438f;
            //double dName = 0.123456789101112131415d;

            //Console.WriteLine(fName);

            //Console.WriteLine(dName);


            //var enumEx = new enumExamplee();
            //enumEx.run();

            //var structExample = new StructExample();
            //structExample.Run();

            //var referenceTypeEx = new ReferenceTypeExample();
            //referenceTypeEx.run();

            //var stringEx = new StringExample();
            //stringEx.run();

            //var explictConv = new ExplictConversion();
            //explictConv.run();

            //var statementExp = new StatementExample();
            //statementExp.run();

            var conditionState = new ConditionalStatement();
            conditionState.run();
               

            Console.ReadKey();

            


        }
    }
}
