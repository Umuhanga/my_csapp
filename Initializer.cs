using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using contactbook.Models;

namespace contactbook
{
    public static class Initializer
    {
        public static void Initialize(IServiceProvider provider)
        {
            var options = provider.GetRequiredService<DbContextOptions<ContactDBcontext>>();
            using (var context = new ContactDBcontext(options))
            {
                context.Database.EnsureCreated();
                Contacts c = new Contacts
                {
                    Name = "Nacky",
                    Surname = "Uwanyirigira",
                    Email = "@aa",
                    PhoneNumber = 21,
                    Birth = 1
                };
                context.SaveChanges();

            }
        }
    }
}
