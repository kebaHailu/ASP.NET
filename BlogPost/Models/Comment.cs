using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPost.Models
{
    // The comment table which inherit from base entity
    public class Comment:BaseEntity
    {
        public int Post_Id { get; set;}

        public virtual Post? Post {get; set; }

        public Comment(){
            
        }
        
    }
}