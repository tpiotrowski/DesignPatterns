﻿using System;

namespace Visitor
{
    internal class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("ConcreteElementA.OperationA()");
        }
    }
}