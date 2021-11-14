using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi ees- ja perekonnanimi
            //kuvab mitu 'a' tähte on sisestatud ees- ja perekonnanimes

            Console.WriteLine("Palun sisesta eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Palun sisesta perekonnanimi:");
            string lastname = Console.ReadLine();

            string fullName = $"{firstname} {lastname}".ToLower();

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu nimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on üks 'a' täht.");
            }

            
        }
    }
}
