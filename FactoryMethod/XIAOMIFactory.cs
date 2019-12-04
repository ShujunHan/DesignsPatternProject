using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class XIAOMIFactory : MobileFactory
    {
        public Mobile ProductMobile()
        {
            Console.WriteLine("小米手机开始制造");
            return new XIAOMI();
        }
    }
}
