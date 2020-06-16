using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlueTeamBlog.Models.Database
{
    public class Blog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; } = DateTime.Now;


        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

        public virtual ICollection<Post> Posts { get; set; }   
}
}