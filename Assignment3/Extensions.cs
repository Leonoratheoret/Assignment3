using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public static class Extensions
    {

        public static void Flatten()
        {
            var x = new List<int> {1, 2, 3, 4, 5};
            var s = new List<int> {6, 7, 8, 9, 10};
            List<int>[] xs = new[] {x, s};

            var flattenXS = xs.SelectMany(i => i);
            foreach (var VARIABLE in flattenXS) Console.WriteLine(VARIABLE);
        }
        
        public static void Divisble()
        {
            var x = new List<int> {2, 7, 14, 42, 49, 70, 80};
            var filtredX = x.Where(i => i > 42 && i % 7 == 0);
            
            foreach (var VARIABLE in filtredX) Console.WriteLine(VARIABLE);
        }
        
        public static void LeapYear()
        {
            var x = new List<int> {1820, 1822, 2000, 2001, 2012, 2016, 2017, 2020};
            var filtredX = x.Where(i =>
            {
                if (i % 4 == 0)  { //Tests if "normal" leap year
                    if(i % 100 != 0 || i % 400 == 0) { //Tests special cases of leap years
                        return true; 
                    }
                    else {
                        return false;
                    }
                } else {
                    return false;
                }
            });
            
            foreach (var VARIABLE in filtredX) Console.WriteLine(VARIABLE);
        }
    }
}
