using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPost.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPost.data
{
    public class ApiDbContent: DbContext
    {
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comment {get;set;}
        public ApiDbContent(DbContextOptions<ApiDbContent> options): base(options){

        }

        // here we will use one-to-many relationship for one post with multiple comment
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Comment>(entity =>{
                entity.HasKey(c => c.Id);
                entity.HasOne(p => p.Post)
        
                .WithMany(c => c.Comments)
                .HasForeignKey(p => p.Post_Id)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Comment_Post");

            });
            modelBuilder.Entity<Post>(entity =>{
                entity.HasKey(p => p.Id);
            });
        }
    }
}