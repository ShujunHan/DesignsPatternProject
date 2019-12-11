﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
