using LeetCode.Problems;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Problem pm = new Problem();
            var list = pm.LexicalOrder(13);
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
