using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlueTeamBlog.Models.Database
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM,dd,yyyy}")]
        public DateTime Created { get; set; }

        public virtual Post Post { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}