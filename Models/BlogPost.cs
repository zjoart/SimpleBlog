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
        public string Title { get; set; }
        public string Label { get; set; }
        public int Like { get; set; }
        public string Body { get; set; }

        public BlogPost()
        {
          
        }

    }

    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommentBody { get; set; }
        public byte BlogPostId { get; set; }

        public Comment()
        {

        }
    }
}
