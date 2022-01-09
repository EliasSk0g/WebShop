using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Datasource;
using WebShop.DTO;

namespace WebShop.DataAccess
{
    public class ProductsDataAccess : IDataAccess
    {
        private readonly JsonDataSource _dataSource;

        

        public ProductsDataAccess(JsonDataSource datasource)
        {
            _dataSource = datasource;
        }

        public IEnumerable<ProductsDTO> GetProducts()
        {
            string jsonRes = _dataSource.ProductData();
            return JsonConvert.DeserializeObject<IEnumerable<ProductsDTO>>(jsonRes);
        }
       
        public IEnumerable<CustomersDTO> GetAllCustomers()
        {
            string jsonRes = _dataSource.CustomerData();
            return JsonConvert.DeserializeObject<IEnumerable<CustomersDTO>>(jsonRes);


        }
       
        public CustomersDTO GetCustomerById(int id)
        {
            string jsonResponse = _dataSource.CustomerData();
            foreach (CustomersDTO user in GetAllCustomers())
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
        public ProductsDTO GetProductsById(int id)
        {
            string jsonResponse = _dataSource.ProductData();
            foreach (ProductsDTO product in GetProducts())
            {
                if (product.ProdId == id)
                {
                    return product;
                }
            }
            return null;
        }
        public void SaveCustomer(CustomersDTO cust)
        {
            string jsonRes = _dataSource.CustomerData();
            var customers = JsonConvert.DeserializeObject<IEnumerable<CustomersDTO>>(jsonRes).ToList();
            for (int i = 0; i < customers.Count(); i++)
            {
                if (cust.Id == customers[i].Id)
                {
                    customers[i] = cust;
                    var updatedData = JsonConvert.SerializeObject(customers, Formatting.Indented);
                    _dataSource.UpdateCustData(updatedData);
                    break;
                }
            }

        }
        public void SaveItem(ProductsDTO item)
        {
            string jsonRes = _dataSource.ProductData();
            var items = JsonConvert.DeserializeObject<IEnumerable<ProductsDTO>>(jsonRes);
            var newList1 = items.ToList();
            newList1.Add(item);
            var updateditemData = JsonConvert.SerializeObject(newList1);
            _dataSource.UpdateProdData(updateditemData);
        }



    }
}




    

