﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson09.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}