using System;
using System.Collections.Generic;

namespace NewsArticles.Models
{
    public class Article
    {
        public Int32 ArticleId { get; set; }
        public String Title { get; set; } = null!;
        public String Description { get; set; } = null!;
        public Int16 ReadTime { get; set; } 
        public String ImageURL { get; set; } = null!;
    }
}
