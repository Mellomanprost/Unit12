using System;
using System.Collections.Generic;

namespace Unit12._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user1 = new User("Alex90", "Alex", true);
            User user2 = new User("Maximus", "Maxim", false);
            User user3 = new User("Gurman", "Gosha", true);
            User user4 = new User("Sunshine", "Ann", false);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            foreach(var user in users)
            {
                Console.WriteLine($"Добро пожаловать {user.Name}!");
                if (!user.IsPremium)
                {
                    Console.WriteLine("Для продолжения работы дождитесь окончания рекламы.");
                    User.ShowAds();
                }
                Console.WriteLine("Вход в систему осуществлен!\n");

            }
        }
    }
}
