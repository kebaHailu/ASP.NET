using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogPost.Models;
using BlogPost.data;


namespace BlogPost.Controller;

[ApiController]
[Route("api/[controller]")]
public class CommentController: ControllerBase
{  
    private readonly ApiDbContent _Content;
    private CommentController(ApiDbContent content){
        _Content = content;

    } 

   
    [HttpGet]
    public IActionResult Get(){
        var cont = _Content.Comment.ToList();
        return Ok(cont);


    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id){
        var comment = _Content.Comment.FirstOrDefault(x=>x.Id == id);
        if (comment == null){
            return BadRequest("Invalid Id");
        }
        return Ok(comment);
    }


    [HttpPost]
    public IActionResult Post(Comment comment){
        _Content.Comment.Add(comment);
        return CreatedAtAction("Get",comment.Id,comment);
    } 
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id){
        var deleted_elm = _Content.Comment.Find(id);
        if (deleted_elm == null){
            return BadRequest("Id not found!");
        }
        _Content.Comment.Remove(deleted_elm);
        return Ok($"Deleted {id}");
    }
    [HttpPatch("{id:int}")]
    public IActionResult Patch(int id, Comment comment){
        var Updated_Comment = _Content.Comment.FirstOrDefault(x => x.Id == id);
        if (Updated_Comment == null){
            return BadRequest("ID can't be foun !");

        }
        Updated_Comment.Id = comment.Id;
        Updated_Comment.Post_Id = comment.Post_Id;
        Updated_Comment.Created = comment.Created;
        Updated_Comment.Content = comment.Content;
        Updated_Comment.Post = comment.Post;
        _Content.SaveChanges();
        return Ok("Updated Successful!");
        

    }
}
