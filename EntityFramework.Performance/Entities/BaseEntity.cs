﻿using System;

namespace EntityFramework.Performance.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}