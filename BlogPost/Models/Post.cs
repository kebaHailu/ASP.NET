using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPost.Models
{
    // the post table which inherit from base entity
    public class Post:BaseEntity
    {
        
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        public string Title { get; set; } = "";

        public virtual ICollection<Comment> Comments { get; set; }

    }
}