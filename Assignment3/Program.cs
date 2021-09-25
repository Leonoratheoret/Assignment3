using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Uri u = new Uri("https://docs.microsoft.com/en-us/dotnet/api/system.uri?view=net-5.0");
            // u.IsSecure();


            string s = "Hej med dig. Hvad hedder du";
            //Console.WriteLine(s.WordCount());
            
            OurDelegates.ReverseString(s);


            Console.WriteLine(OurDelegates.Product(10, 5));
            Console.WriteLine(OurDelegates.NumericallyEqual("898",898));

             
        
        }
    }
}
