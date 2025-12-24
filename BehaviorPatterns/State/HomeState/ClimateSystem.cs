namespace HomeState
{
    public class ClimateSystem
    {
        public int Temperature { get; set; }
        private State _state;

        public ClimateSystem(State state)
        {
            _state = state;
        }

        public void CheckTemperature()
        {
            State newState = _state.Handle(this);

            if (newState != _state)
            {
                _state = newState;
                Console.WriteLine($"Состояние изменено на {_state.GetType().Name}");
                _state.Info();
            }
            else
            {
                _state.Info();
            }
        }
    }
}