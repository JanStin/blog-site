﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Domain.Entities
{
    public class ArticleEntity : BaseEntity
    {
        public string Tag { get; set; }
        
        public ArticleEntity(int id, string title, string description, string imagePath, string article, string metaKeywords, string tag)
        {
            Id = id;
            Title = title;
            Description = description;
            ImagePath = imagePath;
            Article = article;
            MetaTitle = title;
            MetaDescription = description;
            MetaKeywords = metaKeywords;
            DateAdded = DateTime.UtcNow;
            Tag = tag;
        }
    }
}
