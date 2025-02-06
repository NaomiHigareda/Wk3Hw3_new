using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WEEK3EXAMPLE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input;
            int selection = 0;

            do
            {
                Console.WriteLine("Please input a string?");
                input = Console.ReadLine(); // read user input stirng
                Console.WriteLine("Please input a number for options below:" +
                    "\n 1: Reverse String \n 2: Number of Vowels \n 3: Check Palindrome \n 4: Exit");
                selection = Convert.ToInt32(Console.ReadLine()); // read option user selects
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Reveresed: " + ReverseString(input));
                        break;
                    case 2:
                        Console.WriteLine("Number of Vowels: " + CountVowels(input));
                        break;
                    case 3:
                        Console.WriteLine("Is Palindrome: " + IsPalindrome(input));
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (selection <4);
           
        }
        public static string ReverseString(string input)
        {
            //return input.Reverse().ToString();

            string retValue =string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            { 
                retValue += input[i];
            }

            return retValue;
        }
        public static int CountVowels(string input)
        {
            int retVal = 0;

            // process counting vowels
            int counter = 0;
            foreach (char ch in input) // iterate each character in input string
            {
                input = input.ToLower(); // convert all characters to lower case
                
                switch (ch) 
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        counter = counter + 1;
                        break;
                    default:
                        break;
                
                }
            }
            retVal = counter;
            return retVal;

            
        }
        // palindrome is a word that has the order of charaters the same from the beginning or from the end: racecar, madam
        public static bool IsPalindrome(string input)
        {
            bool retVal = false;

            string reversedstring = ReverseString(input);

            if (reversedstring == input)
            {
                retVal = true;
            }

            return retVal;

        }
            
        
        }
    }