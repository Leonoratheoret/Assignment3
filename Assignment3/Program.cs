using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri u = new Uri("https://docs.microsoft.com/en-us/dotnet/api/system.uri?view=net-5.0");
            Console.WriteLine("is secure?: " + u.IsSecure());

            string s = "Hej med dig. Hvad hedder du";
            Console.WriteLine(s.WordCount());
            
            OurDelegates.ReverseString(s);
        }
    }
}
