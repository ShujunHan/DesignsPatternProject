using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolUser user = null;
            user = SimpleFactory.GetSchoolUser("Patercia", "Patercia");

            Console.WriteLine("校长登陆");

            user.Show();

            user = SimpleFactory.GetSchoolUser("Teacher", "Teacher");
            Console.WriteLine("教师登陆");
            user.Show();

            Console.ReadKey();
        }
    }
}
