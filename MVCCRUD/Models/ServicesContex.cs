using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCRUD.Models
{
    public class ServicesContex:DbContext
    {

        public DbSet<Product> Products { get; set; }
    }
}