using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InputOutput
{
    public class FileProcessing
    {
        public static string[] ReadWords(string file)
        {
            var ordListe = new List<string>();

            using (StreamReader reader = new StreamReader(file, Encoding.GetEncoding("iso-8859-1")))
            {
                for (int i = 0; i < 30; i++)
                {
                    reader.ReadLine();
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var word = line.Split('\t')[1];
                    if (!word.Contains('-') || !word.Contains(' ') || !char.IsUpper(word[0]))
                        ordListe.Add(word.ToLower());

                }
                
            }

            return ordListe.Distinct().ToArray();
        }
    }
}