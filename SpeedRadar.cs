using System.Collections.Generic;

namespace Practice_2
{
    class SpeedRadar: IMessageWritter
    {
        private List<float> speedHistory = new List<float>();
        private const float legalSpeed = 50.0f;
        private string lastPlate = "";
        private float lastSpeed = 0.0f;

        public void TriggerRadar(VehicleWithPlate vehicleWithPlate)
        {
            lastSpeed = vehicleWithPlate.GetSpeed();
            lastPlate = vehicleWithPlate.GetPlate();
            speedHistory.Add(lastSpeed); 
        }

        public string GetLastReading()
        {


            if (lastSpeed > legalSpeed) { return WriteMessage("Catched above legal speed."); }

            else { return WriteMessage("Driving legally."); }
        }

        public List<float> GetSpeedHistory()
        {
            return speedHistory; 
        }

        public string WriteMessage(string message)
        {
            return $"Vehicle with plate {lastPlate} driving at {lastSpeed} km/h. {message}";
        }
        
    }
}
