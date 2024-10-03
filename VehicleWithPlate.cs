namespace Practice_2
{
    class VehicleWithPlate: Vehicle
    {
        private string plate;

        public VehicleWithPlate(string typeOfVehicle, string plate): base(typeOfVehicle)
        {
            this.plate = plate;
            Console.WriteLine(WriteMessage("Created"));
        }
        public string GetPlate()
        {
            return plate;
        }
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }
    }
}
