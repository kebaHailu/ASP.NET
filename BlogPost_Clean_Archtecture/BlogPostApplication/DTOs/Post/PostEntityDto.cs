using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Application.DTOs.Post
{
    public class PostEntityDto
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";

        public PostEntityDto()
        {
            Comments = new HashSet<CommentEntityDto>();
        }

        public virtual ICollection<CommentEntityDto> Comments { get; set; }
    }
}
