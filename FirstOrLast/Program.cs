using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi ees- ja perekonnanimed;
            //kontrolli andmete pikkust eraldi;
            //kuva pikema nime;

            Console.WriteLine("Palun sisestage eesnimi:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Palun sisestage perekonnanimi:");
            string lastname = Console.ReadLine();

            if(firstname.Length > lastname.Length)
            {
                Console.WriteLine($"Pikem nimi on {firstname}");
            }
            else if(lastname.Length > firstname.Length)
            {
                Console.WriteLine($"Pikem nimi on {lastname}");
            }
            else
            {
                Console.WriteLine("Mõlemad nimed on sama pikkusega.");
            }

            
        }
    }
}
