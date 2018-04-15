﻿using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main()
        {
            var component = new ConcreteComponent();
            var concreteDecoratorA = new ConcreteDecoratorA();
            var concreteDecoratorB = new ConcreteDecoratorB();

            concreteDecoratorA.SetComponent(component);
            concreteDecoratorB.SetComponent(concreteDecoratorA);
            concreteDecoratorB.Operation();

            Console.ReadKey();
        }
    }
}