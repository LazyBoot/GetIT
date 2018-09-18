using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace StartList
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "startlist.csv";

            var registrations = UsingParser(file);
        }

        private static List<Registration> UsingParser(string file)
        {
            var registrations = new List<Registration>();

            using (var parser = new TextFieldParser(file))
            {
                parser.SetDelimiters(",");
                if (!parser.EndOfData)
                    parser.ReadFields();

                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields();
                    registrations.Add(new Registration(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]));
                }
            }

            return registrations;
        }

        private static List<Registration> UsingStreamReader(string file)
        {
            var registrations = new List<Registration>();

            using (var reader = new StreamReader(file))
            {
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var fields = line.Split(',');
                    var startNumber = fields[0].Trim('"');
                    var name = fields[1].Trim('"');
                    var club = fields[2].Trim('"');
                    var nationality = fields[3].Trim('"');
                    var @group = fields[4].Trim('"');
                    var @class = fields[5].Trim('"');
                    registrations.Add(new Registration(startNumber, name, club, nationality, @group, @class));
                }
            }

            return registrations;

        }
    }
}
