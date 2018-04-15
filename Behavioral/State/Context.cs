using System;

namespace State
{
    internal class Context
    {
        private State _state;

        public Context(State state)
        {
            State = state;
        }

        public State State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}