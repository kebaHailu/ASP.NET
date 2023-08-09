using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPost.Models
{
    // the general stracture for all tables
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Content { get; set; } = "";
        public DateTime Created { get; set; }

    }
}