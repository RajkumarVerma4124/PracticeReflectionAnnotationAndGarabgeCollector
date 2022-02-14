using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Validating sequences
            Console.WriteLine("Validating alphabet and number sequences : ");
            ValidateSequences();

            //Validating pincode
            Console.WriteLine("Validating pincode : ");
            ValidatePincode();
            Console.ReadLine();
        }

        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return Math.Abs(first - second);
        }

        //Method to validate alphabet and number sequence
        public static void ValidateSequences()
        {
            string[] inputStr = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string pattern = "^[0-9]*[a-zA-Z]{3,}[a-z0-9A-Z]*$";
            IterateOverLoop(inputStr, pattern);
        }

        //Method to validate pincode number
        public static void ValidatePincode()
        {
            string[] inputStr = { "784 561", "9456123", "abc124", "123456", "A456123", "B78456","400701"};
            string pinPattern = "^[0-9]{3}[ ]?[0-9]{3}$";
            IterateOverLoop(inputStr, pinPattern);
        }

        public static void IterateOverLoop(string[] inputStr, string pattern)
        {
            foreach (string input in inputStr)
            {
                bool res = Regex.IsMatch(input, pattern);
                if (res)
                    Console.WriteLine("{0} is Valid", input);
                else
                    Console.WriteLine("{0} is Invalid", input);
            }
            Console.WriteLine();
        }
    }
}
