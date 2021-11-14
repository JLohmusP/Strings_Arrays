using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //ennusta, mis kasutajaga juhtub homme (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            Random rnd = new Random();
            int Prediction = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[Prediction]}.");
        }
    }
}
