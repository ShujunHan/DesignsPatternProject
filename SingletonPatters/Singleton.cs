using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatter
{
    class Singleton
    {

        #region 饿汉式单利
        //private static Singleton Instance = new Singleton;

        //public static Singleton GetInstance()
        //{
        //    return Instance;
        //}
        #endregion

        #region  懒汉式单利
        private static Singleton Instance;

        public static Singleton GetInstace()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }
        #endregion 
    }
}
