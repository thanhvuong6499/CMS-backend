using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBackend.Models.Entity.OutsideArticle
{
    public class OutsideArticle
    {
        public int ArticleId { get; set; }
        public string ArticleType { get; set; }
        public int DisplayOrder { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy{ get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Status { get; set; }
        public DateTime PinDate { get; set; }
    }
}
