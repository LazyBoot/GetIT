namespace OppgaveAbax
{
    public class Boat : Vehicle
    {
        public int GrossTonnage;
        public int TopSpeed;

        public Boat(string regNumber, int enginePower, int topSpeed, VehicleType type, int grossTonnage) : base(regNumber, enginePower, type)
        {
            GrossTonnage = grossTonnage;
            TopSpeed = topSpeed;
            TopSpeedUnit = "knop";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Bruttotonnasje: {GrossTonnage}kg. Topphastighet: {TopSpeed} {TopSpeedUnit}.";
        }

    }
}
