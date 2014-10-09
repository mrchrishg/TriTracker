using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using TriTracker.Web.Models;
using System.Data.Entity;
using TriTracker.Model;


namespace TriTracker.Web.DataContexts
{

        public class ApplicationDb : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDb()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDb Create()
            {
                return new ApplicationDb();
            }

            public DbSet<Activity> Activities { get; set; }

            public DbSet<ActivitySegment> ActivitySegments { get; set; }

            public DbSet<Race> Races { get; set; }

            public DbSet<Athlete> Athletes { get; set; }

        }
}