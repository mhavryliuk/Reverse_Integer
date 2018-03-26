using System;

/* https://leetcode.com/problems/reverse-integer/description/
 * Given a 32-bit signed integer, reverse digits of an integer.
 * Assume we are dealing with an environment which could only hold integers within the 32-bit signed integer range. 
 * For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows. */

namespace _00007_ReverseInteger
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input your integer number: ");
            int x = int.Parse(Console.ReadLine());

            Solution answer = new Solution();
            Console.WriteLine("Answer: " + answer.Reverse(x));

            Console.ReadKey();
        }
    }
}
