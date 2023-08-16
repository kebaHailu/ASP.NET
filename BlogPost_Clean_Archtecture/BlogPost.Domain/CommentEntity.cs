using BlogPost.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;


namespace BlogPost.Domain
{
    public class CommentEntity: BaseEntity
    {
        public int PostId { get; set; }
        public string Text { get; set; }

        public virtual PostEntity? Post { get; set; }


    }
}
