using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.ViewModels
{
    public  class BlogViewModel
    {
        public BlogPost BlogPosts { get; set; }
        public  List<Comment> Comments { get; set; } 
        public BlogViewModel()
        {
            Comments = new List<Comment>();
        }

       
    }
}

