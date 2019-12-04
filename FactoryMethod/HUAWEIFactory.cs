using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class HUAWEIFactory : MobileFactory//华为制造实例的工厂
    {
        public Mobile ProductMobile()
        {
            Console.WriteLine("华为手机开始制造");
            return new HUAWEI();
        }
    }
}
