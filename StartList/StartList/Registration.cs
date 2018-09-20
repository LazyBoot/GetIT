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

        public Registration(string[] line)
        {
            StartNumber = line[0];
            Name = line[1];
            Club = line[2];
            Nationality = line[3];
            Group = line[4];
            Class = line[5];
        }

        public Registration(string startNumber, string name, string club, string nationality, string group, string @class)
        {
            StartNumber = startNumber;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = group;
            Class = @class;
        }

        public override string ToString()
        {
            return $"{StartNumber} - {Name} - {Club} - {Nationality} - {Group} - {Class}";
        }
    }
}
