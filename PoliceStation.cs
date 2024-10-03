using System.Collections.Generic;

namespace Practice_2
{
    class PoliceStation : IMessageWritter
    {
        private List<PoliceCar> registeredPoliceCars = new List<PoliceCar>();
        private AlarmController alarmController; 
        private int stationNumber;
        private City city;

        public PoliceStation(int stationNumber, City city)
        {
            this.stationNumber = stationNumber;
            this.city = city;
            this.alarmController = new AlarmController(new Alarm(), this);
        }

        public void RegisterPoliceCar(Vehicle vehicle)
        {
            if (vehicle is PoliceCar policeCar)
            {
                registeredPoliceCars.Add(policeCar); 
                alarmController.RegisterPoliceCar(policeCar);
                Console.WriteLine(WriteMessage($"Registered police car with plate {policeCar.GetPlate()}"));
            }

        }

        public void ActivateAlarm(VehicleWithPlate vehicleWithPlate)
        {
            alarmController.ActivateAlarm(vehicleWithPlate);
        }

        public void DesactivateAlarm()
        {
            alarmController.DeactivateAlarm();
        }

        public int GetStationNumber()
        {
            return stationNumber;
        }

        public string WriteMessage(string message)
        {
            return $"Police Station: {message}"; // Formato del mensaje de la comisaría
        }
    }
}
