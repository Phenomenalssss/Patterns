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

        public void SetState(State state)
        {
            _state = state;
            Console.WriteLine($"Состояние изменено на {state.GetType().Name}");
            _state.Info();
        }

        public void CheckTemperature()
        {
            _state.Handle(this);
        }
    }
}