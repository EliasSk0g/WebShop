using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebShop.DTO
{
    public class CartDTO
    { 
        public List<ProductsDTO> Products { get; set; }

        public CartDTO()
        {
            Products = new List<ProductsDTO>();
        }
    }
}
