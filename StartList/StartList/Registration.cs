using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartList
{
    public class Registration
    {
        public string StartNumber;
        public string Name;
        public string Club;
        public string Nationality;
        public string Group;
        public string Class;

        public Registration(string startNumber, string name, string club, string nationality, string group, string @class)
        {
            StartNumber = startNumber;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = group;
            Class = @class;
        }
    }
}
