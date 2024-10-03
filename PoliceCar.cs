using System;

namespace Practice_2
{
    class PoliceCar : VehicleWithPlate
    {
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling = false;
        private bool isChasing = false; 
        private RadarController? radarController; // Manejo del radar
        private PoliceStation policeStation; // Referencia a la comisaría

        public PoliceCar(string plate, PoliceStation policeStation, SpeedRadar? speedRadar = null) : base(typeOfVehicle, plate)
        {
            this.policeStation = policeStation;
            if (speedRadar != null)
            {
                radarController = new RadarController(speedRadar, this); 
            }
        }
        // PATRULLAR FUNCIONA
        public void StartPatrolling()
        {
            if (!isPatrolling) 
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
            
        }

        public void StopPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }

            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
            
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void UseRadar(Vehicle vehicle)
        {   
            if (radarController != null)
            {
                if (isPatrolling)
                {
                    radarController?.UseRadar(vehicle);
                }
                else
                {
                    Console.WriteLine(WriteMessage("is not patrolling."));
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("does not have a radar."));
            }
        }
        public void PrintRadarHistory()
        {
            radarController?.PrintRadarHistory();
        }

        public void StartAlarm(VehicleWithPlate vehicleWithPlate)
        {
            policeStation.ActivateAlarm(vehicleWithPlate); // Activa la alarma en la comisaría
        }

        public void StopAlarm()
        {
            policeStation.DesactivateAlarm(); // Desactiva la alarma en la comisaría
        }

        public void ChaseVehicle(VehicleWithPlate vehicleWithPlate)
        {
            isChasing = true;
            Console.WriteLine(WriteMessage($"Starts chasing vehicle with license plate {vehicleWithPlate.GetPlate()}."));
        }

        public void StopChaseVehicle()
        {
            if (isChasing)
            {
                isChasing = false;
                Console.WriteLine(WriteMessage("Stopped chasing the vehicle."));
            }
            else
            {
                Console.WriteLine(WriteMessage("Is not chasing a vehicle."));
            }
        }

        public bool IsChasing()
        {
            return isChasing;
        }
    }
}