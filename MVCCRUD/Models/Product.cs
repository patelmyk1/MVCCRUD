using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCCRUD.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        
        [Required]
        public string ProductName { get; set; }
    }
}