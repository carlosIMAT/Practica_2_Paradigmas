namespace Practice_2
{
    class City: IMessageWritter
    {
        private List<Taxi> registeredTaxis = new List<Taxi>();
        private List<PoliceStation> policeStations = new List<PoliceStation>();
        private string name;

        public City(string name) 
        {
            this.name = name;
            Console.WriteLine(WriteMessage("Created."));
        }

        public void RegisterTaxi(Vehicle vehicle)
        {
            if (vehicle is Taxi taxi)
            {
                registeredTaxis.Add(taxi);
                Console.WriteLine(WriteMessage($"Registered taxi with license plate {taxi.GetPlate()}"));
            }
            else
            {
                Console.WriteLine(WriteMessage("Can not register a vehicle that is not a taxi."));
            }
        }

        public void EliminateTaxi(Vehicle vehicle)
        {
            if (vehicle is Taxi taxi)
            {
                registeredTaxis.Remove(taxi);
                Console.WriteLine(WriteMessage($"The taxi with license plate {taxi.GetPlate()} has been removed from the database."));
            }
            else
            {
                Console.WriteLine(WriteMessage($"Can not eliminate from the dabase a vehicle that is not a taxi."));

            }
        }

        public PoliceStation CreatePoliceStation(int stationNumber)
        {
            PoliceStation policeStation = new PoliceStation(stationNumber, this);
            policeStations.Add(policeStation);
            Console.WriteLine(WriteMessage($"Police station {stationNumber} has been created."));

            return policeStation;
        }

        public override string ToString()
        {
            return $"{name}";
        }
        
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}