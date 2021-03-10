using System;

namespace NoNew_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //new NoNew(); // error, because constructor of class NoNew is PRIVATE
            NoNew.CreateInstance();
        }
    }
}
