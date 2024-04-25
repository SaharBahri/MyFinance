using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Category
    {
        public int categoryId { get; set; }
        public string Name { get; set; }
        virtual public ICollection<Product> Products { get; set; }
    }
}
