using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Models
{
    public class BlogPost
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Your Post should have a title")]
        [Display(Name = "Post Title")]
        public string Title { get; set; }
        public string Label { get; set; }
        [Display(Name = "Likes")]
        public int Like { get; set; }
        public string PostImage { get; set; }

        [Required(ErrorMessage = "Your Post should have a Body")]
        [Display(Name = "Post Body")]
        public string Body { get; set; }

        public BlogPost()
        {
          
        }

    }

    public class Comment
    {
        public int Id { get; set; }

        [Display(Name = "Commenter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Your Comment should have a Body")]
        [Display(Name = "Comment body")]
        public string CommentBody { get; set; }
        public byte BlogPostId { get; set; }

        public Comment()
        {

        }
    }
}
