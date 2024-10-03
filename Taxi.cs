﻿namespace Practice_2
{
    class Taxi : VehicleWithPlate
    {
        private const string typeOfVehicle = "Taxi";
        private bool isCarryingPassengers = false;

        public Taxi(string plate) : base(typeOfVehicle, plate) 
        {
            SetSpeed(45.0f);
        }
        public void StartRide()
        {
            if (!isCarryingPassengers)
            {
                isCarryingPassengers = true;
                SetSpeed(100.0f);
                Console.WriteLine(WriteMessage("starts a ride."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already in a ride."));
            }
        }

        public void StopRide() 
        {
            if (isCarryingPassengers)
            {
                isCarryingPassengers= false;
                SetSpeed(45.0f);
                Console.WriteLine(WriteMessage("finishes ride."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is not in a ride."));
            }
        }
    }
}