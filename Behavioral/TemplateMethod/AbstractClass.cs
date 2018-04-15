using System;

namespace TemplateMethod
{
    internal abstract class AbstractClass
    {
        protected abstract void PrimitiveOperation1();

        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine(string.Empty);
        }
    }
}