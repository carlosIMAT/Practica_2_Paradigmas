namespace Practice_2
{
    class AlarmController
    {
        private Alarm alarm;
        private List<PoliceCar> policeCars;
        private PoliceStation policeStation;

        public AlarmController(Alarm alarm, PoliceStation policeStation)
        {
            this.alarm = alarm;
            this.policeCars = new List<PoliceCar>();
            this.policeStation = policeStation;
        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            policeCars.Add(policeCar);
        }

        public void ActivateAlarm(VehicleWithPlate vehicleWithPlate)
        {
            if (!alarm.IsActive())
            {
                alarm.ChangeState();
                Console.WriteLine(policeStation.WriteMessage("The alarm has been activated."));

                foreach (var policeCar in policeCars)
                {
                    if (policeCar.IsPatrolling())
                    {
                        policeCar.ChaseVehicle(vehicleWithPlate);
                    }
                }
            }
            else
            {
                Console.WriteLine(policeStation.WriteMessage("The alarm is already active."));
            }
        }

        public void DeactivateAlarm()
        {
            if (alarm.IsActive())
            {
                alarm.ChangeState();
                Console.WriteLine(policeStation.WriteMessage("The alarm has been desactivated."));

                foreach (var policeCar in policeCars)
                {
                    policeCar.StopChaseVehicle();
                }
            }
            else
            {
                Console.WriteLine(policeStation.WriteMessage("The alarm is not active."));
            }
        }
    }
}
