namespace Practice_2
{
    class Vehicle: IMessageWritter
    {
        private string typeOfVehicle;
        private float speed = 0.0f;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
        }
        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }
        public float GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }
        public override string ToString() 
        {
            return $"{GetTypeOfVehicle()}";
        }
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}
