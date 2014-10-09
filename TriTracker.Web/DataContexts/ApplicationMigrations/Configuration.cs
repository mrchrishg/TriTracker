namespace TriTracker.Web.DataContexts.ApplicationMigrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TriTracker.Model;
    using TriTracker.Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TriTracker.Web.DataContexts.ApplicationDb>
    {
        const string _defaultPassword = "Password 00";
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\ApplicationMigrations";
        }

        protected override void Seed(TriTracker.Web.DataContexts.ApplicationDb context)
        {
            if (context.Users.Any(u => u.Email == "me@chrishg.com"))
                return; //Already have data, get out

            var user = CreateUser(context, "me@chrishg.com", _defaultPassword);
            var athlete = new Athlete
            {
                FirstName = "Chris",
                LastName = "HG",
                PreferredEmail = "me@chrishg.com",
                DateOfBirth = new DateTime(1978,03,27),
                AspNetUserId = user.Id
            };
            athlete = CreateAthlete(context, athlete);
            
            var activities = new List<Activity>
            {
                new Activity{ 
                    Athlete = athlete,
                    ActivityType=ActivityType.Swim,
                    Distance = 750,
                    TimeTaken = 1307,
                    StartDateTime = new DateTime(2014,9,7,9,5,0,DateTimeKind.Local),
                    StartLocation = "East Coast Park, Singapore"
                    },
                new Activity{ 
                    Athlete = athlete,
                    ActivityType=ActivityType.Cycle,
                    TimeTaken = 1958,
                    Distance = 19800,
                    StartDateTime = new DateTime(2014,9,7,9,5,0,DateTimeKind.Local),
                    StartLocation = "East Coast Park, Singapore"
                    },
                new Activity{ 
                    Athlete = athlete,
                    ActivityType=ActivityType.Run,
                    Distance = 5000,
                    TimeTaken = 1511,
                    StartDateTime = new DateTime(2014,9,7,9,5,0,DateTimeKind.Local),
                    StartLocation = "East Coast Park, Singapore"
                    },
                
            };


            CreateActivities(context, activities);
        }

        private void CreateActivities(ApplicationDb context, List<Activity> activities)
        {
            foreach (var activity in activities)
                context.Activities.Add(activity);
            context.SaveChanges();
        }

        private Athlete CreateAthlete(ApplicationDb context, Athlete athlete)
        {
            context.Athletes.Add(athlete);
            context.SaveChanges();

            return athlete;
        }

        private ApplicationUser CreateUser(ApplicationDb context, string email, string password)
        {
            var hasher = new PasswordHasher();
            var user = new ApplicationUser { UserName = email, Email = email, PasswordHash = hasher.HashPassword(password) };
            context.Users.AddOrUpdate(user);
            context.SaveChanges();

            return user;
        }
    }
}
