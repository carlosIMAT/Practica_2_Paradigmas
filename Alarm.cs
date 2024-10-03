namespace Practice_2
{
    class Alarm
    {
        private bool isActive = false;
        public Alarm() { }

        public void ChangeState()
        {
            isActive = !isActive;
        }

        public bool IsActive()
        {
            return isActive;
        }
    }
}
