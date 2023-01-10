namespace State
{
    public abstract class State
    {
        protected TrafficLight _trafficLight;

        public TrafficLight TrafficLight
        {
            get => _trafficLight;
            private set => _trafficLight = value;
        }

        public void Setter(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public abstract void NextState();
        public abstract void PreviuosState();
    }
}