using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
