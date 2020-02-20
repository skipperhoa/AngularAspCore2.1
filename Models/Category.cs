using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BasicAspCore.Models
{
    public class Category
    {
        [Key]
        public int idCategory { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
