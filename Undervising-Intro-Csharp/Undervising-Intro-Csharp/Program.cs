using System;

namespace UndervisningIntroCS
{
    class Program
    {
        /* To ting inne i en klasse
         *      Felt - tilsvarer (nesten) JavaScript globale variabler.
         *      Metoder - tilsvarer funksjon i JavaScript
         * 
         * Pensum i dag:
         *      C# er et sterkt typet programmeringsspråk
         *      Intro til Visual Studio
         *      Debugging
         *      Grunnskjelettet i en class
         *      Variabler, tilordning og datatyper
         *          bool - boolean (true/false)
         *          int - heltall
         *          float/double - desimaltall
         *          string - tekst
         *      Valgsetning
         *      Løkker -for og while sim i JavaScript - foreach (for tabeller)
         *      Tabeller
         *      Metoder (funksjoner)
         *      Input og output
         */
         
        static void Main(string[] args)
        {
            // Deklarere en variabel av hver av de nevnte datatypene.

            bool b;
            int i;
            float f;
            double d;
            string s;

            // Tilordning
            b = true;
            i = 5;
            f = 3.2f;
            d = 1.2;
            s = "Text";

            // Kan også deklarere og tilordne samtidig
            bool b2 = false;
            int i2 = 3;
            float f2 = 1.3f;
            double d2 = 7.7;
            string s2 = "kjh";

            var b3 = false;
            var i3 = 9;
            var f3 = 5.5f;
            var d3 = 9.9;
            var s3 = "eagh";

            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Hallo! Ingen parametre.");
            //}
            //else
            //{
            //    Console.WriteLine("Hello World! Antall parametere " + args.Length);
            //}

            //foreach (var text in args)
            //{
            //    Console.WriteLine("Parameter: " + text);
            //}
        }
    }
}
