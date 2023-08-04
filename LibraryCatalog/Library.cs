using System;
using System.Collections.Generic;


namespace Library{
    public class Library{
        public string? Name {get; set;}
        public string? Address{get;set;}

        List<Book> Books = new List<Book>();
        List<MediaItem> mediaItems= new List<MediaItem>();


        public void AddBook(Book book){
            Books.Add(book);
        }
        public void RemoveBook(Book book){
            Books.Remove(book);
        }
        public void AddMeidaItem(MediaItem item){
            mediaItems.Add(item);
        
        }
        public void RemoveMediaItem(MediaItem item){
            mediaItems.Remove(item);
        }

        public void PrintCatalog(){
            Console.WriteLine("Books");
            foreach(var book in Books){
                Console.WriteLine($"Title - {book.Title} by {book.Author}");
                Console.WriteLine($"ISBN - {book.ISBN}");
                Console.WriteLine($"Publication Year {book.PublicationYear}");
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Media Items");
            foreach(var item in mediaItems){
                Console.WriteLine($"Title - {item.Title}");
                Console.WriteLine($"Media Type - {item.MediaType}");
                Console.WriteLine($"Duration - {item.Duration}");
                Console.WriteLine();
                
            }
        }
        
        
    }
}