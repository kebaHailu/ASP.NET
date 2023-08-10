using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPost.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogPost.Models;

     
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

        [HttpPost]
        public IActionResult Add(Post post){
            var posts = _Content.Posts.Add(post);
            _Content.SaveChanges();
            return Ok("Changes saved!");
        

        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id){
            var post = _Content.Posts.FirstOrDefault(x => x.Id == id);
            if (post == null){
                return BadRequest("Id not found!");
            }

            return Ok(post);
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id){
            var deleted_post = _Content.Posts.Find(id);
            if (deleted_post != null){
                return BadRequest("Id can't be found!");
            }
            _Content.Posts.Remove(deleted_post);
            return Ok("Deleted successful");

        }
        [HttpPatch]
        public IActionResult Patch(int id,Post post){

            var updated_post = _Content.Posts.FirstOrDefault(x => x.Id == id);
            if (updated_post == null){
                return BadRequest("Invalid Id!");

            }
            updated_post.Title = post.Title;
            updated_post.Comments = post.Comments;
            updated_post.Created = post.Created;
            updated_post.Content = post.Content;

            _Content.SaveChanges();

            return NoContent();
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
