using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicAspCore.Models;
namespace BasicAspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {
        public EFDataContext _context;
        public ProductController(EFDataContext context)
        {
            this._context = context;
        }

        public IEnumerable<Product> Get()
        {
            var da = _context.Products.ToList();
            return da;
        }
    }
}