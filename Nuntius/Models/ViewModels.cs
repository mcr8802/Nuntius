﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nuntius.Models
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public IList<Comment> Comments { get; set; }
        public Subscription Subscription { get; set; }
        public int Favourite { get; set; }

    }

    public class NewsSource
    {
        public Newsheadline Newsheadline;
        public Source Source;
    }

    public class ArticleSource
    {
        public Article Article;
        public Source Source;
        public IList<Article> Articles;
    }
}