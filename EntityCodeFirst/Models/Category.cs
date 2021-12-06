using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityCodeFirst.Models
{
    [Table("tblCategories")]
    public class Category    //this is a domain class through which we are defining categories table
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}