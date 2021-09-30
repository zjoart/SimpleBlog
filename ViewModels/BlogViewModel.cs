using Microsoft.AspNetCore.Http;
using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class BlogImageViewModel
    {
        public BlogPost BlogPost { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]  
        [Display(Name = "Profile Picture")]  
        public IFormFile PostImage { get; set; } 
        public BlogImageViewModel()
        {

        }

    }
}

