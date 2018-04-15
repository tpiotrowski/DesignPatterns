namespace Prototype
{
    internal abstract class Prototype
    {
        protected Prototype(string id)
        {
            Id = id;
        }

        public string Id { get; }

        public abstract Prototype Clone();
    }
}