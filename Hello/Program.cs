using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine("Siema, " + item);
            }
            //string imie = args[i];
            //Console.WriteLine("siema, " + imie);
        }
    }
}
