using System.Diagnostics.Metrics;

namespace Practice_2
{
    class RadarController
    {
        private SpeedRadar speedRadar;
        private PoliceCar policeCar;

        public RadarController(SpeedRadar speedRadar, PoliceCar policeCar)
        {
            this.speedRadar = speedRadar; 
            this.policeCar = policeCar;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (vehicle is VehicleWithPlate vehicleWithPlate)
            {
                speedRadar.TriggerRadar(vehicleWithPlate); 
                string measurement = speedRadar.GetLastReading(); 
                Console.WriteLine(policeCar.WriteMessage($"Radar triggered. Result: {measurement}"));
            }
            else
            {
                Console.WriteLine(policeCar.WriteMessage("The radar can not be used in a vehicle with no plate."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(policeCar.WriteMessage("Radar speed history report:"));
            foreach (float speed in speedRadar.GetSpeedHistory())
            {
                Console.WriteLine(speed); 
            }
        }
    }
}
