using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebShop.DTO
{

    public class ProductsDTO
    {
        [JsonProperty]
        public int Id { get; set; }

        [JsonProperty]
        public string Brand { get; set; }

        [JsonProperty]
        public string Color { get; set; }
        [JsonProperty]
        public int Price { get; set; }
       


    }
}
