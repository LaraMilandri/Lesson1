namespace BlaisePascal.Lesson1.ClassVehicle
{
    public class Vehicle
    {
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public string LicensePlate { get; private set; }

        public int OdometerKm {
            get
            {  return _odometerKm; }
            private set
            { if (value < 0) throw new ArgumentException("illegal value");
                        _odometerKm = value ; } }

        public double DailyRate { get; private set; }

        public double FuelLevelPercentage { get; private set; }

        /// <summary>
        /// metodo costruttore
        /// </summary>
        /// <param name="licensePLate"></param>

        public Vehicle(string licensePLate)
        {
            LicensePlate = licensePLate; //chiamata al private set

        }
        
        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        {

        }

    }
}
