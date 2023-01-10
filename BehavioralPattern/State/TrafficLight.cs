namespace State
{
    public class TrafficLight
    {
        private State _state;

        public TrafficLight(State state)
        {
            SetState(state);
        }

        public void SetState(State state)
        {
            _state = state;
            _state.Setter(this);
        }

        public void NextState()
        {
            _state.NextState();
        }

        public void PreviuosState()
        {
            _state.PreviuosState();
        }
    }
}