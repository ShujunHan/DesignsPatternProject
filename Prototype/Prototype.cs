using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    abstract class Prototype
    {
        private string id;

        public Prototype( string str)
        {
            id = str;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }
}
