using System;

namespace DesignsPatternProject
{
    class Program
    {

        #region Builder Pattern
        //static void Main(string[] args)
        //{


        //    Director director = new Director();//创建指挥者

        //    Builder builderA = new ConcreteBuilderA();//创建具体执行者A

        //    Builder builderB = new ConcreateBuilderB();//创建具体执行者B


        //    director.Build(builderA);//给具体执行者A赋值，让里面的方法执行
        //    Product productA = builderA.GetRestult();//给产品角色赋值   
        //    productA.Show();//显示出来

<<<<<<< HEAD

        //    director.Build(builderB);
        //    Product productB = builderB.GetRestult();
        //    productB.Show();
        //    Console.ReadKey();
=======
            //同上
            director.Build(builderB);
            Product productB = builderB.GetRestult();
            productB.Show();
            Console.ReadKey();
>>>>>>> 9a5002e1388c2f4364a304ff6665b275534a4142

        //}
        #endregion

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("123456");
        //    Console.ReadKey();
        //}

    }
}
