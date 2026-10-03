namespace BlaisePascal.Lesson1.ClassVehicle
{
    public class Vehicle
    {
        private int _id;
        //private string _licensePlate;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        public string LicensePlate { get; private set; }

        /// <summary>
        /// metodo costruttore
        /// </summary>
        /// <param name="licensePLate"></param>
        
        public Vehicle(string licensePLate)
        {
            LicensePlate = licensePLate; //chiamata al private set

        }
        
        

    }
}
