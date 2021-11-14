using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //kuva mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!";

            string hellow = "Hello World!".ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for(int i = 0; i < hellow.Length; i++)
            {
                if(hellow[i] == 'h')
                {
                    hCounter++;
                }

                if(hellow[i] == 'o')
                {
                    oCounter++;
                }

                if(hellow[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses 'Hello World!' esineb sümbolit 'h' {hCounter} korda, 'o' {oCounter} korda ja 'l' {lCounter} korda");
        }
    }
}
