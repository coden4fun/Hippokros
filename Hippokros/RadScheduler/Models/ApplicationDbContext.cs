using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RadSchedule.Models
{
    public class ApplicationDbContext :IdentityDbContext<User>
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Projection> Projections { get; set; }
    }
}