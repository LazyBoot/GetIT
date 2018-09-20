using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Linq;

namespace StartList
{
    class Program
    {
        static void Main()
        {
            const string inFile = "startlist.csv";
            const string outFile = "startList.txt";

            var registrationModel = new RegistrationModel();
            UsingParser(inFile, registrationModel);

            using (var output = new Output(new StreamWriter(outFile, false)))
            {
                foreach (var club in registrationModel.Clubs.OrderByDescending(c => c.Registrations.Count).ThenBy(c => c.Name))
                {
                    output.WriteLine(club.Name);
                    output.WriteLine("-------------------------");
                    output.WriteLine($"Totalt påmeldte: {club.Registrations.Count.ToString()}");

                    foreach (var registration in club.Registrations.GroupBy(r => r.Class))
                    {
                        output.WriteLine($"{registration.Key} - {registration.Count()}");
                    }

                    output.WriteLine(string.Empty);
                }
            }
        }

        private static void UsingParser(string file, RegistrationModel registrationModel)
        {
            using (var parser = new TextFieldParser(file))
            {
                parser.SetDelimiters(",");
                if (!parser.EndOfData)
                    parser.ReadFields();

                while (!parser.EndOfData)
                {
                    var line = parser.ReadFields();
                    if (line == null) continue;

                    registrationModel.HandleLine(line);
                }
            }
        }

        // ReSharper disable once UnusedMember.Local
        private static void UsingStreamReader(string file, RegistrationModel registrationModel)
        {
            using (var reader = new StreamReader(file))
            {
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    registrationModel.HandleLine(line);
                }
            }
        }
    }
}
