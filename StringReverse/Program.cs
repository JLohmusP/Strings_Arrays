using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //kuva kasutaja eesnime tagurpidi

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstname = Console.ReadLine();

            for(int i = firstname.Length-1; i >= 0; i--)
            {
                Console.Write(firstname[i]);
            }
        }
    }
}
