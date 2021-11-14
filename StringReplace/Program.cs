using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //asenda kõik 'o' tähed lauses "Hello world!" tärniga (*)

            string hellow = "Hello world!";

            /*for(int i=0; i < hellow.Length; i++)
            {
                hellow[i] = '*'; //sõned on muutumatud
            }*/

            hellow = hellow.Replace('o', '*');
            hellow = hellow.Replace('!', '1');
            Console.WriteLine(hellow);
        }
    }
}
