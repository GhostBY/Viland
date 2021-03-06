﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.BLL.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; }

        public string Header { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}
