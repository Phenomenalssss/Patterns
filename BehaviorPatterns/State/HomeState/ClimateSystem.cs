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
            _state = _state.Handle(this);
            Console.WriteLine($"Состояние изменено на {_state.GetType().Name}");
            _state.Info();
        }
    }
}