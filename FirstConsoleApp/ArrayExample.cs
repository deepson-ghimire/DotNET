using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class ArrayExample
    {

        // single dimensional array
        // multi dimensional array int[,] 
        // jagged array int[][] jagged = new int[2][];  2 ley katio otta row banauni 
        // 
        public void run()
        {
            //example();
            //hobbiesExample();
            //multiplicationTable();
            jaggedExample();
        }


        private void example()
        {
            int[] data = new int[10];
            for (int i = 0; i < data.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                data[i] = num;
            }

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]+ " ");

            }
        }
        // Wap create an singular array of string named hobbies and add any of your 5 hobbies into it. Ask all 5 hobbies from console.Readline(. Use for loop)
        // a. afrer completing the loop for 5 times. Ask a user if they want to add few more hobbies
        // if yes then How many more hobbies user want to add and repeat the proess for that amount of time

        private void hobbiesExample()
        {
            string [] data = new string[5];

            for (int i = 0; i < data.Length; i++)
            {
                string hobbies = Console.ReadLine();
                data[i] = hobbies;
            }


            Console.WriteLine("Do you want to add more hobbies, if yes then type ~yes~");
            string dec = Console.ReadLine();
            
            if(dec == "yes")
            {
                Console.WriteLine("Enter a number how many hobbies you want to add");
                int num = Convert.ToInt32(Console.ReadLine());
                string[] newdata = new string[num];

                for(int i = 0;i < newdata.Length; i++)
                {
                    string newHobbies = Console.ReadLine();
                    newdata[i] = newHobbies;
                }

                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(data[i]);
                }

                for (int i = 0; i < newdata.Length; i++)
                {
                    Console.WriteLine(newdata[i]);
                }

            }

            else if (dec == "no")
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(data[i]);
                }
            }

            else
            {
                return;
            }
        
            
        }

        // 
        private void multiplicationTable()
        {
            int[,] multiplication = new int[10, 10];
            for (int i = 0; i < multiplication.GetLength(0); i++)
            {
                for (int j = 0; j < multiplication.GetLength(1); j++)
                {
                    multiplication[i, j] = (i+1) * (j+1);
                }
            }

            for (int i = 0;i < multiplication.GetLength(0); i++)
            {
                for(int j = 0;j < multiplication.GetLength(1); j++)
                {
                    Console.Write(multiplication[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < 10; i++) { 
            //    for(int j = 0;j < 10; j++)
            //    {
            //        Console.WriteLine()
            //    }
            //}
        }
        
        private void jaggedExample()
        {
            int[][] data= new int[5][];

            data[0] = new int[3];
            data[1] = new int[3];
            data[2] = new int[3];
            data[3] = new int[5];
            data[4] = new int[4];

            for(int i= 0; i<data.Length; i++)
            {
                Console.WriteLine($"Enter marks for student{i + 1}");
                for(int j = 0; j<data[i].Length; j++)
                {
                    Console.WriteLine($"Enter marks for subject {j + 1}: ");
                    var inputData = Console.ReadLine();
                    int num = Convert.ToInt32(inputData);
                    data[i][j] = num;
                }
            }

            for(int i = 0; i < data.Length; i++)
            {
                for(int j = 0; j < data[i].Length; j++)
                {
                    Console.Write(data[i][j] + " ");
                }
                Console.WriteLine() ;
            }
        }
    }
}
