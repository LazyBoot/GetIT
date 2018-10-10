namespace OppgaveAbax
{
    public class Vehicle
    {
        public string RegNumber;
        public int EnginePower;
        public string TopSpeedUnit = "km/h";
        public VehicleType Type;

        public Vehicle(string regNumber, int enginePower, VehicleType type)
        {
            RegNumber = regNumber;
            EnginePower = enginePower;
            Type = type;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: RegNumber: {RegNumber}. Motorkraft: {EnginePower} kw.";
        }
    }
}
