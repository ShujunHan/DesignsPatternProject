using System;
using System.Collections.Generic;
using System.Text;

namespace TempleateMethod
{
    abstract class DateObject
    {
        public abstract void Connect();

        public abstract void Select();

        public abstract void Process();

        public abstract void Disconnect();

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
