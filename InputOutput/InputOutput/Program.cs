namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args.Length != 0 ? args[0] : "fullform_bm.txt";

            var fullOrdListe = FileProcessing.ReadWords(file);

            var ordListe = WordProcessing.CheckLength(fullOrdListe);

            var funnetOrd = 0;
            while (funnetOrd < 200)
            {
                if (WordProcessing.FindWord(ordListe, fullOrdListe))
                    funnetOrd++;
            }
        }
    }
}
