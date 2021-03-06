﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueTeamBlog.Models.Database
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<Post> TagPosts { get; set; }
    }
}