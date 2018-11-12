using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EntityFramework1.Models
{[Table("tblCategories")]
    public class Category
    {
        [Key]
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }

    }
}