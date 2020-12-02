using System;

namespace EntityFramework.Performance.Entities
{
    public class TermAndCondition : BaseEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}