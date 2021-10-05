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
        [Required(ErrorMessage = "Your Post should have a title")]
        [Display(Name = "Post Title")]
        public string Title { get; set; }
        public string Label { get; set; }
        [Display(Name = "Likes")]
        public int Like { get; set; }
  
        [Required(ErrorMessage = "Your Post should have a Body")]
        [Display(Name = "Post Body")]
        public string Body { get; set; }
        [Required(ErrorMessage = "Please choose post image")]  
        [Display(Name = "Post Image")]  
        public IFormFile PostImage { get; set; } 
        public BlogImageViewModel()
        {

        }

    }
}

