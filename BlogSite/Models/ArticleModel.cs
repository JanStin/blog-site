﻿using BlogSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace BlogSite.Models
{
    public class ArticleModel
    {
        
        public ArticleEntity Article { get; set; }
        
        
        public ArticleEntity Init(int id)
        {
            // TODO: Сделать запрос в БД, чтобы получить статью по id.
            if (id < 0 || id > 100)
            {
                return null;
            }

            Article = new ArticleEntity(id, "Название " + id.ToString(), "Большое описание на несколько строк", @"C:\Users\Rico\Desktop\Уч. материалы\RedFoxDev\img\_TwB97Q_OSo.jpg", "Tag", "Lorem.Paragraphs(120, 2, 2).ToString()", "Key, Word, То что надо");

            return Article;
        }

    }

        // TODO: Сделать запрос в БД, чтобы получить статью по id.

}
