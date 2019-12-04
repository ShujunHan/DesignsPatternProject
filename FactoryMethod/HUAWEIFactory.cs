using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class HUAWEIFactory : MobileFactory
    {
        public Mobile ProductMobile()
        {
            Console.WriteLine("华为手机开始制造");
            return new HUAWEI();
        }
    }
}
