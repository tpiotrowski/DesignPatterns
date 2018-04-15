using System;

namespace Observer
{
    internal class ConcreteObserver : Observer
    {
        private readonly string _name;
        private string _observerState;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            _name = name;
        }

        private ConcreteSubject Subject { get; }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
        }
    }
}