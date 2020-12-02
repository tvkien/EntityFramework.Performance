using EntityFramework.Performance.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFramework.Performance.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var userId = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId,
                Email = "abc@abc.com"
            });

            modelBuilder.Entity<TermAndCondition>().HasData(new TermAndCondition
            {
                Id = Guid.NewGuid(),
                UserId = userId
            }, 
            new TermAndCondition
            {
                Id = Guid.NewGuid(),
                UserId = userId
            });

            modelBuilder.Entity<EngagementUser>().HasData(new EngagementUser
            {
                Id = Guid.NewGuid(),
                UserId = userId
            },
            new EngagementUser
            {
                Id = Guid.NewGuid(),
                UserId = userId
            });
        }
    }
}