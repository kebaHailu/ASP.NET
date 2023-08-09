using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogPost.Models;

namespace BlogPost.Controller;

[ApiController]
[Route("api/[controller]")]
public class CommentController: ControllerBase
{   
    List<Comment> comments = new List<Comment>(){
        new Comment(){ 
            Id = 1,
            Content = "Hello I like your comment",
            Created = DateTime.Now,
            Post_Id = 1
        },
        new Comment(){
            Id = 2,
            Content = "You are misstaken you should say that you liked his post",
            Created = DateTime.Now,
            Post_Id = 1
        },
        new Comment(){  
            Id = 3,
            Content = "Thanks for that ",
            Created = DateTime.Now,
            Post_Id = 1
        }
    };
    [HttpGet]
    public IActionResult Get(){

        return Ok(comments);

    }
    
}
