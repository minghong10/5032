namespace FIT5032_Week08A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

 
    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        [AllowHtml]
        public string Comments { get; set; }
    }
}
