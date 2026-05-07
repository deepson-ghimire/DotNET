using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Student
{
    namespace Model 
    { 
        internal class StudentModel
        {
            public readonly int id;
            public string name;
            public int marks;

            public StudentModel(int id, string name, int marks)
            {
                this.id = id;
                this.name = name;
                this.marks = marks;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"My name is {name}. I have got {marks} marks. My id is {id}");
            }

            public void UpadateMarks(ref int marks)
            {
                this.marks = marks;
            }

            public bool isPassed()
            {
                if(marks>40)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
