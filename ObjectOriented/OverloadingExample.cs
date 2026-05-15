using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    //Compile time 
    internal class OverloadingExample
    {
        public void run()
        {
            BillCalculator billCalculator = new BillCalculator();
            billCalculator.item(500, 5, 20);
        }
    }

    class Operation
    {
        public void Add() { }

        

        public void Add(int a)
        {
            Console.WriteLine(a);
        }

        public void Add(int a,int b)
        {
            Console.WriteLine(a);
        }

        public void Add(int a, double b)
        {
            Console.WriteLine(a);
        }

        public void Add(double a, int b)
        {
            Console.WriteLine(a);
        }
    }

}

    // Write a program with a class BillCalculator that overloasds the calculateBIll method in three ways
    // Calculate bill for one item(price)
    // calculate bill for multiple item (price, quantity)
    //calculate bill for multiple items with discount(price , quantity, discount)

    class BillCalculator
    {
        public void item(double price)
        {
            Console.WriteLine(price);
        }

        public void item(double price, int quantity)
        {
            Console.WriteLine(price * quantity);
        }

        public void item(double price, int quantity, double discount)
        {
            double total = price * quantity;
            double discountAmt = total - (total * (discount / 100));
            Console.WriteLine(discountAmt);
        }
    }
