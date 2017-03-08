using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharpExercises
{
    class Player
    {
        public string name;
        public int guess; 
    }
    class Program
    {
        static void PrintIntArray(int[] numArray)
        {
            for(int i =0; i < numArray.Length; ++i)
            {
                Console.WriteLine(numArray[i]);
            }
        }
        static void reverseString(string someWord)
        {
            for(int i = someWord.Length - 1; i >= 0; --i)
            {
                Console.Write(someWord[i]);
            }
        }
         static bool palindromeChecker(string someWord)
        {
            bool isItAPalindrome = false;
            for(int i = 0; i <= someWord.Length/2; i++)
            {
                if (someWord[i] == someWord[someWord.Length - 1-i])
                {
                    isItAPalindrome = true;
                }
                else if(i == someWord.Length - 1)
                {
                    isItAPalindrome = true;
                   
                }
                else
                {
                    isItAPalindrome = false;
                    i = someWord.Length;
                }
            }

            return isItAPalindrome;
        }

        static Player[] GetWinner(Player[] players, int correctValue)
        {
            for(int i = 0; i < players.Length; i++)
            {
                players[i].guess
            }
        }
        static void Main(string[] args)
        {

            //int[] things = { 5, 7, 9 };
            //Console.WriteLine("Hello World");
            //PrintIntArray(things);
            string Word = "hello";
            
            //reverseString(Word);
           Console.Write(palindromeChecker(Word));

            Console.ReadLine();
        }
    }
}
