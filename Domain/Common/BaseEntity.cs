using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class BaseEntity<TKey> : IEntity
    {
        public TKey Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
