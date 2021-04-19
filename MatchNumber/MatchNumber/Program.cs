using System;
using System.Collections.Generic;

//to use stack
namespace MatchNumber
{
    class Program
    {
        static bool match(string input)
            //Will return "true" if there is a pair of each input number, otherwise "false"
        {
            Stack<int> stack = new Stack<int>(); 
            foreach (char ch in input)
            {
                if (stack.Count == 0 || ch != stack.Peek())
                {
                    stack.Push(ch);
                }
                else
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("--- Hello , Please enter the number series you want to test --- ");
            string test = Console.ReadLine();

            Console.WriteLine("Result: {0}" , match(test));
        }
    }
}