using System;

namespace EntityFramework.Performance.Entities
{
    public class EngagementUser : BaseEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}