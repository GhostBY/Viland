using System;
using System.ComponentModel.DataAnnotations;

namespace Viland.DAL.Entities
{
    public class Article
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