using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    // An indexer allow an objext to be incexed like an array
    // a class can have more htan one indecwe but of differ in numbers or type of paramenters
    // private type[] items = new TYpe [size]

    // public TYpe this [int index]
    internal class IndexerExample
    {
        public void run()
        {

            var studentMarks = new StudentMarks();
            studentMarks[0] = 10;
            studentMarks[1] = 20;
            studentMarks[2] = 30;
            studentMarks[3] = 35;

            Console.WriteLine(studentMarks[0]);

            var studentList = new StudentList();
            studentList[0] = "Ramey";

            Console.WriteLine(studentList[0]);

        }
    }

    class StudentMarks
    {
        private int[] marks = new int[10];

        public int this[int index]
        {
            get { return marks[index]; }
            set { marks[index] = value; }
        }
    }

    class StudentList
    {
        private string[] name = new string[5];

        public string this[int index] {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }
}