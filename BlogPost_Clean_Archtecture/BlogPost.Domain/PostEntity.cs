using BlogPost.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Domain
{
    public class PostEntity : BaseEntity
    {
       
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";

        public PostEntity() {
            Comments = new HashSet<CommentEntity>();
        }

        public virtual ICollection<CommentEntity> Comments {get; set; }
    }
}
