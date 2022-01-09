using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Datasource
{
    public class JsonDataSource
    {
        public string ProductData()
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\elias\source\repos\WebShop\WebshopData\Products.Mockdata.json");
           return jsonRepsonse;
        }
        public string CustomerData()
        {
            var jsonresponse = File.ReadAllText(@"C:\Users\elias\source\repos\WebShop\WebshopData\Customers.Mockdata.json");
            return jsonresponse;

        }
        public void UpdateCustData(string updatedCustData)
        {
            var path = @"C:\Users\elias\source\repos\WebShop\WebshopData\Customers.Mockdata.json";
            File.WriteAllText(path, updatedCustData);
        }
        public void UpdateProdData(string updatedProdData)
        {
            var path = @"C:\Users\elias\source\repos\WebShop\WebshopData\Products.Mockdata.json";
            File.WriteAllText(path, updatedProdData);
        }

    }
}
