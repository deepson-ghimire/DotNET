using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class StringExample
    {
        public void run()
        {
            //example();
            findLongestWord();
        }

        private void findLongestWord()
        {
            string input = Console.ReadLine();
            var splittedWord = input.Split(' ');
            string longestWord = "";

            foreach (var word in splittedWord)
            {
                if (word.Length > longestWord.Length) longestWord = word;
            }
                Console.WriteLine(longestWord);
        }
        private void example() {
            string fname = "ramey";
            string lname = "yadhav";

            string fullName = fname + lname; 
            //Console.WriteLine(fullName);

            string fullNameMessage = $"My fullname is {fname} {lname}.";
            //Console.WriteLine(fullNameMessage);


            int stringLength = fullName.Length;

            // it take 2 parameter
            // first = where to start
            //second = number of charcacter;
            string subString = fname.Substring(2, 2); // it will print "me" form the fname.
            //Console.WriteLine(subString);

            //Console.Write("Enter your name");
            //string name = Console.ReadLine();


            string splitString = "my,name,is,ramey";
            var splitedString = splitString.Split(',');
            //Console.WriteLine(splitedString);



        }
    }
}
