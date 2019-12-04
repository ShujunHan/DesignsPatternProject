using System;

namespace SingletonPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.GetInstace() == Singleton.GetInstace()); ;
            Console.ReadKey();
        }
    }
}
