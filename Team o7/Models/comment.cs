using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Org.BouncyCastle.Bcpg;

namespace jaj.Models
{
    public class comment
    {
        public int commentID { get; set; }
        public int cvideoID { get; set; }
        public int commentUserID { get; set; }
        public DateTime commentTime { get; set; }
        public string commentContent { get; set; }

        [NotMapped]
        public HttpPostedFileBase CommentSection { get; set; }
    }
}