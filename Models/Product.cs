using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BasicAspCore.Models
{
    public class Product
    {
        [Key]
        public int idProduct { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int idCategory { get; set; }
        public virtual Category Category { get; set; }
    }
}
