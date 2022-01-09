using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DTO
{
    public class CustomersDTO
    {
        
            public int Id { get; set; }
        [JsonProperty]
        public string FirstName { get; set; }
        [JsonProperty]
        public string LastName { get; set; }
        public string receipt { get; set; }
    }
}