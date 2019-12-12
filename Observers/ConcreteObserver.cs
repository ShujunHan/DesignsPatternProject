using System;
using System.Collections.Generic;
using System.Text;

namespace Observers
{
    class ConcreteObserver : ObServer
    {
        public void OnUpdate(object obj)
        {
            Console.WriteLine("Receive:" + obj);
        }
    }
}
