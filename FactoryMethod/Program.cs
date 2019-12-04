using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile;
            MobileFactory mobileFactory;

            mobileFactory = new HUAWEIFactory();
            mobile = mobileFactory.ProductMobile();
            mobile.Call();


            mobileFactory = new XIAOMIFactory();
            mobile = mobileFactory.ProductMobile();
            mobile.Call();
            Console.ReadKey();
        }
    }
}
