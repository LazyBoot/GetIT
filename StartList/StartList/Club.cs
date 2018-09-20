using System.Collections.Generic;

namespace StartList
{
    public class Club
    {
        public string Name { get; }
        public List<Registration> Registrations = new List<Registration>();

        public Club(string name)
        {
            Name = name;
        }

        public void AddRegistration(Registration registration)
        {
            Registrations.Add(registration);
        }
    }
}
