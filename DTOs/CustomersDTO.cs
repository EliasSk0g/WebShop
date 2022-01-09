using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WebShop.DataAccess
{
    public class CustomersDTO
    {
        [JsonProperty][Key]
            public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
    }
}