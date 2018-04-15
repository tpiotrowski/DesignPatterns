﻿using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main()
        {
            var singleton1 = Singleton.Instance();
            var singleton2 = Singleton.Instance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Objects are the same instance!");
            }

            Console.ReadKey();
        }
    }
}