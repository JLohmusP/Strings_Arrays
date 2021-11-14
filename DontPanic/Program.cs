using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //asenda kõik 'o' tähed lauses "Don't Panic" nulliga
            //asendab kõik 'a' tähed neljaga

            string panic = "Don't Panic";

            panic = panic.Replace('o', '0');
            panic = panic.Replace('a', '4');
            Console.WriteLine(panic);
        }
    }
}
