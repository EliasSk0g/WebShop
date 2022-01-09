using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.DTO;

namespace WebShop.DataAccess
{
   public interface IDataAccess
    {
        IEnumerable<ProductsDTO> GetProducts();
       
       IEnumerable<CustomersDTO> GetAllCustomers();
        void SaveCustomer(CustomersDTO cust);
        void SaveItem(ProductsDTO item);
    
        public CustomersDTO GetCustomerById(int id);
        public ProductsDTO GetProductsById(int id);
    }

    
}
