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
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            var reverseString = new string(chars);

            Action<string> ReverseString = s => Console.WriteLine(reverseString);
            ReverseString(s);

        }

        public static double Product(double number1, double numebr2)
        {
             Func<double,double,double> product = (x, y) => x * y;
             return product(number1, numebr2); 
        }

        public static bool NumericallyEqual(string numericalString, int number)
        {
             Func<string, int,bool> numericallyEqual = (s, i) => 
             {
                try {
                var intValue = int.Parse(s);
                if(intValue == i) return true;
                return false;
                } catch (Exception) {
                return false;
                }
             };
             return numericallyEqual(numericalString, number); 
        }

        
    }
}