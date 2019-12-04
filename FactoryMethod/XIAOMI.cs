using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class XIAOMI : Mobile
    {
        public void Call()
        {
            Console.WriteLine("华为生产");
        }
    }
}
