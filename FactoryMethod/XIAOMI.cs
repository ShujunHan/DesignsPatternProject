using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class XIAOMI : Mobile//重写实现主要的功能
    {
        public void Call()
        {
            Console.WriteLine("华为生产");
        }
    }
}
