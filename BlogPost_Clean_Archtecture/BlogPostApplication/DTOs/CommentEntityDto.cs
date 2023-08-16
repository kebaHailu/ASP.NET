using System;
using System.Collections.Generic;
using System.Text;
using BlogPost.Application.DTOs.Post;

namespace BlogPost.Application.DTOs
{
    public class CommentEntityDto
    {
        public int PostId { get; set; }
        public string Text { get; set; }

        public virtual PostEntityDto? Post { get; set; }
    }
}
