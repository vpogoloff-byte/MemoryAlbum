using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Program
    {
        class User
        {
            public string name;
            public int age;

        }
        static User getUser()
        {
            var user = new User();

            user.name = "Martin";
            user.age = 10;

            return user;
        }
        
        static void Print(User user)
        {
            Console.WriteLine($"Имя: {user.name}");
            Console.WriteLine($"Возраст: {user.age}");
        }
        static void Main(string[] args)
        {
           var firstUser = getUser();

            Print(firstUser);


        }
    }
}
