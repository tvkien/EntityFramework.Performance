using System.Collections.Generic;

namespace EntityFramework.Performance.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }

        public ICollection<EngagementUser> EngagementUser { get; set; }

        public ICollection<TermAndCondition> TermAndCondition { get; set; }
    }
}