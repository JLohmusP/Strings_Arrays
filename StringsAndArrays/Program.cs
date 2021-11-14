using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi eesnime;
            //kuvab kasutaja eesnime pikkuse;

            Console.WriteLine("Sisesta eesnimi:");
            string firstname = Console.ReadLine();

            //int firstnamelength = firstname.Length;
            Console.WriteLine($"Sinu eesnimes on {firstname.Length} sümbolit.");
        }
    }
}
