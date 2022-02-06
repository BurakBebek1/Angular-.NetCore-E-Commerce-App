using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "'Burak'",
                    Email = "burakbebek1994@gmail.com",
                    UserName = "burakbebek1994@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Burak",
                        LastName = "Bebek",
                        Street = "10. Sokak",
                        City = "Hatay",
                        State = "Akdeniz",
                        ZipCode = "31000"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}