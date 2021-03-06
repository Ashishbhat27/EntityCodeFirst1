using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityCodeFirst.Models
{
    [Table("tblProducts")]
    public class Product      //this is a domain class through which we are defining Products table
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }
    }
}