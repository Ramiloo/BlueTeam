using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlueTeamBlog.Models.Database
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [StringLength(10000)]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM, dd,yyyy}")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [StringLength(1000)]
        public string Tags { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}