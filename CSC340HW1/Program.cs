using System;
using System.IO;

namespace CSC340HW1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ProblemOne();
            //ProblemTwo();
            //ProblemTwoP2(-81);
            //ProblemThree();

            //just undo the comment for whichever one you would like to test
        }

        private static void ProblemOne()
        {
            Console.WriteLine("Please input a string, any string.");
            string str = Console.ReadLine().ToLower();
            //takes input from a user, converts everything to lowercase to making checking for vowels easier

            int count = 0;
            foreach(char c in str)
            {
                if ("aeiou".IndexOf(c) >= 0) count++;
            }
            //count goes up by 1 for each character that is in the index of "aeiou", in other words count goes up for each vowel

            if (count == 1) Console.WriteLine("There is 1 vowel in your string.");
            else Console.WriteLine("There are " + count + " vowels in your string.");
            //if statement only for grammatical purposes
        }

        private static void ProblemTwo()
        {
            int b;
            Console.WriteLine("Please input a positive integer.");
            string str = Console.ReadLine();
            //just asking the user to input a positive integer

            while(!int.TryParse(str, out b))
            {
                Console.WriteLine("That string is invalid.");
                Console.WriteLine("Please input a positive integer.");
                str = Console.ReadLine();
            }
            //if the input cannot be converted to an integer then the system will continue to have the user input strings

            b = int.Parse(str);
            if(b < 0)
            {
                Console.WriteLine("That number is invalid.");
                ProblemTwo();
                return;
            }
            //if the number is negative then the program will use recursion to make sure the user doesn't try inputting a non-integer value
            //the return statement is just so that in the case where recursion must be used the program doesn't attempt to continue after
            //the recursion

            if (b % 3 == 0) Console.WriteLine(b + " is divisible by three.");
            else Console.WriteLine(b + " isn't divisible by three.");
            /*just checks to see if the integer can be divided evenly by three
            there's another simpler way to do this with parameters but this way is more fun, i'll make my next method 
            that way just in case you would prefer that way */
        }

        private static void ProblemTwoP2(int b)
        {
            if (b < 0) Console.WriteLine("This is a negative integer.");
            //just checking to see if b is a negative integer
            else
            {
                if (b % 3 == 0) Console.WriteLine(b + " is divisible by three.");
                else Console.WriteLine(b + " isn't divisible by three.");
            }
            //same thing i did in the last version of ProblemTwo
        }

        private static void ProblemThree()
        {
            StreamReader input = new StreamReader("input.txt");
            string str = input.ReadToEnd().ToLower();
            //just opening the text file and converting it to a string in full

            int count = 0;
            foreach(char c in str)
            {
                if ("aeiou".IndexOf(c) >= 0) count++;
            }

            if (count == 1) Console.WriteLine("There is 1 vowel in your string.");
            else Console.WriteLine("There are " + count + " vowels in your string.");
            //this part is literally the same as what I had in ProblemOne because the problems were essentially the same

            input.Close();
            //just closing the file because that's what i've been taught to do with files
        }
    }
}
