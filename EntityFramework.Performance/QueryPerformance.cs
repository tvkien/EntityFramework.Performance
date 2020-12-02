using EntityFramework.Performance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EntityFramework.Performance
{
    public static class QueryPerformance
    {
        public static void TooManyQueries()
        {
            var stopWatch = Stopwatch.StartNew();

            // Explicit loading
            using (var db = new CoreDbContext())
            {
                IEnumerable<User> users = db.User;

                foreach (var user in users)
                {
                    db.Entry(user).Collection(x => x.EngagementUser).Load();

                    var engUser = user.EngagementUser.ToList();
                }
            }

            Console.WriteLine(stopWatch.Elapsed);
            stopWatch = Stopwatch.StartNew();

            //Eager loading
            using (var db = new CoreDbContext())
            {
                var users = db.User.Include(x => x.EngagementUser).ToList();

                foreach (var user in users)
                {
                    var engUser = user.EngagementUser.ToList();
                }
            }

            Console.WriteLine(stopWatch.Elapsed);
            stopWatch = Stopwatch.StartNew();


            // Using Select for better performance
            using (var db = new CoreDbContext())
            {
                var users = db.User.Select(x => new User
                {
                    Id = x.Id,
                    EngagementUser = x.EngagementUser
                }).ToList();
            }

            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}