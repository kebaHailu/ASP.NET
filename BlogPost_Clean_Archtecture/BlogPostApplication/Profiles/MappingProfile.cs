using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BlogPost.Application.DTOs;
using BlogPost.Application.DTOs.Post;
using BlogPost;

namespace BlogPost.Application.Profiles
{
    public class MappingProfile: Profile
    {
       /* public MappingProfile()
        {
            CreateMap<PostEntity, PostEntityDto>().ReverseMap();
            CreateMap<CommentEntity, CommentEntityDto>().ReverseMap(); 
            CreateMap<PostEntity, PostListEntityDto>().ReverseMap();
        }
       */

    }
}
