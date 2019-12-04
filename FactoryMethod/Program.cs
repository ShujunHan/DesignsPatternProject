using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //创造工厂和产品
            Mobile mobile;
            MobileFactory mobileFactory;
            
            
            mobileFactory = new HUAWEIFactory();//创造华为工厂
            mobile = mobileFactory.ProductMobile();//生产产品
            mobile.Call();//产品实现功能


            mobileFactory = new XIAOMIFactory();//创造小米工厂
            mobile = mobileFactory.ProductMobile();//生产产品
            mobile.Call();//产品实现功能
            Console.ReadKey();
        }
    }
}
