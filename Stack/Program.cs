using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");
            

            Console.WriteLine($"The last element from the stack is : {numbers.Last()}");
            Console.WriteLine("The elements from the stack remain unaltered:");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
    
}
