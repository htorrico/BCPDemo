﻿using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sales.Domain.Base
{
    //public abstract class BaseDomainEvent : INotification
    public  class BaseDomainEvent : INotification
    {
        public BaseDomainEvent()
        {
            EventId = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }
        [Key]
        public virtual Guid EventId { get; init; }
        public virtual DateTime CreatedOn { get; init; }
    }
}