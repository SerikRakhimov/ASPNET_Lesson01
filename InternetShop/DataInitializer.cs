using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetShop
{
    public class DataInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            context.Users.AddRange(new List<User>{
                new User
                {
                    Login = "Admin",
                    Password = "123456"
                },
                new User
                {
                    Login = "User1",
                    Password = "100001"
                },
                new User
                {
                    Login = "User2",
                    Password = "100002"
                }
            });
            context.SaveChanges();
        }
    }
}