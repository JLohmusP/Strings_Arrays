using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string hellow = "Hello World!";

            for (int i = hellow.Length-1; i >= 0; i--)
            {
                Console.Write(hellow[i]);
            }
        }
    }
}
