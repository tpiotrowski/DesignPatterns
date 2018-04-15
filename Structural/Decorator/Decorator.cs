namespace Decorator
{
    internal abstract class Decorator : Component
    {
        private Component Component;

        public void SetComponent(Component component)
        {
            Component = component;
        }

        public override void Operation()
        {
            Component?.Operation();
        }
    }
}