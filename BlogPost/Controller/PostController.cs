using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPost.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

     
namespace BlogPost.Controller;
[ApiController]
[Route("api/[controller]")]

      public class PostController:ControllerBase
    {
        private readonly ApiDbContent _Content;

        public PostController(ApiDbContent Content)
        {
            _Content = Content;
        }

        //get all
        [HttpGet]
        public IActionResult GetAll(){
            var posts = _Content.Posts.ToList();
            return Ok(posts);
        }
        // get by id
        //[HttpGet("{id}")]
        // post
        // put
        // delete

        // public PostController(BlogPost blogPost)
        // {

        // }
        
    }
