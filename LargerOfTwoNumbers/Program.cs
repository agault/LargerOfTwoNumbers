using System;

namespace LargerOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program which takes two numbers from the console and
           // displays the larger of the two.

           //Cw Input first number:
           Console.WriteLine("Please input first number:");
           //var of cr
           var firstNumber = Convert.ToInt32(Console.ReadLine());
           //Cw input Second number:
           Console.WriteLine("Please input second number:");
            //var of cr
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            //if first>2nd return: First larger
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is bigger!");
            }
            else if (firstNumber<secondNumber)
            {
                Console.WriteLine("Second number is bigger!");
            }
            else
            {
                Console.WriteLine("THEY ARE EQUAL!");
            }
            //else second larger
        }
    }
}
