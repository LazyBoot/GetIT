using System;
using System.Collections.Generic;
using System.Linq;

namespace StartList
{
    public class RegistrationModel
    {
        public List<Registration> Registrations { get; }
        public List<Club> Clubs { get; }

        public RegistrationModel()
        {
            Registrations = new List<Registration>();
            Clubs = new List<Club>();
        }

        public void HandleLine(string[] line)
        {
            var registration = new Registration(line);

            if (!string.IsNullOrEmpty(registration.Club))
            {
                var club = Clubs.FirstOrDefault(c => string.Equals(c.Name, registration.Club, StringComparison.CurrentCultureIgnoreCase));
                if (club == null)
                {
                    club = new Club(registration.Club);
                    Clubs.Add(club);
                }

                club.Registrations.Add(registration);
            }

            Registrations.Add(registration);
        }

        public void HandleLine(string line)
        {
            var fields = line.Split(',');
            var startNumber = fields[0].Trim('"');
            var name = fields[1].Trim('"');
            var club = fields[2].Trim('"');
            var nationality = fields[3].Trim('"');
            var @group = fields[4].Trim('"');
            var @class = fields[5].Trim('"');

            Registrations.Add(new Registration(startNumber, name, club, nationality, @group, @class));
        }
    }
}
