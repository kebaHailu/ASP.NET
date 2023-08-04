using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Text;

namespace Library
{
    public class Book{

        public Book(string title){
            Title = title;
        }
        public string? Title { get; set; }
        public string? Author { get; set;}
        public string? ISBN { get; set;}
        public int PublicationYear {get; set;}



        

    }
}