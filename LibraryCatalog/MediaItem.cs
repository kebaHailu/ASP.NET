using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library{
    public class MediaItem{

        public MediaItem(string title){
            Title = title;
        }
        public string? Title { get; set; }
        public string? MediaType { get; set; }
        public int? Duration { get; set; }



    }
}