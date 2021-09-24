using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public static class OurDelegates
    {
        public static void ReverseString(string s)
        {
            var se = s.Reverse();
            Console.WriteLine(se);
            //Action<IEnumerable<char>> reverse = s => Console.WriteLine(se);
        }
    }
}