﻿using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main()
        {
            var abstraction = new RefinedAbstraction { Implementor = new ConcreteImplementorA() };
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            Console.ReadKey();
        }
    }
}