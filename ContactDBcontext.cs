using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using contactbook.Models;

namespace contactbook
{
    public class ContactDBcontext : DbContext
    {
        public ContactDBcontext(DbContextOptions<ContactDBcontext> options) :
            base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseLazyLoadingProxies();
        }
        public DbSet<Contacts> Contacts { get; set; }
    }
}
