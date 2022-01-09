using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebShop.DTO
{

    public class ProductsDTO
    {
        [JsonProperty("productid")]
        public int ProdId { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }

        public int Receipt { get; set; }

        public int PriceTotal;
        [JsonProperty("products")]
        public List<ProductsDTO> Products { get; set; }


    }
}
