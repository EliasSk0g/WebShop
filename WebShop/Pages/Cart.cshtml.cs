using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.DataAccess;
using WebShop.Datasource;
using WebShop.DTO;



namespace WebShop.Pages
{
    public class CartModel : PageModel
    {
        private readonly IDataAccess _dataAccess;
        public CartModel(IDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }


        //private readonly IDataAccess<ItemsDTO> _dataAcess;
        public static List<ProductsDTO> ShoppingCartItem = new List<ProductsDTO>();
        //public CustomerDTO Customer { get; set; }
        [BindProperty]
        public bool toRemove { get; set; }

        [BindProperty]
        public string ReceiptUser { get; set; }
        public List<CustomersDTO> Customers11 { get; set; }
        public void OnGet()
        {
            //int id = (int)HttpContext.Session.GetInt32("UserId");
            //Customer = _dataAccess.GetCustomerById(id);
            //if(ShoppingCartItem == null)
            //{
            //    ShoppingCartItem = Customer.Cart.Products;
            //}
            _dataAccess.GetProducts();
            //summa();
            Customers11 = _dataAccess.GetAllCustomers().ToList();

        }


        public void OnPostCartRemove()
        {
            //var itemToRemove = ShoppingCartItem.Single(r => r.itemId == toRemove);
            //ShoppingCartItem.Remove(ShoppingCartModel.ShoppingCartItem.);
        }

        //public string summa()
        //{
        //    var result = ShoppingCartItem.Sum();
        //    return result;
        //}
        public List<CustomersDTO> CustomerList { get; set; }


        public void OnPostAddReceipt()
        {
            //var item_url = Request.Form["item_url"];
            //var item_name = Request.Form["item_name"];
            //var item_price = Request.Form["item_price"];
            //var item_itemid = Request.Form["item_itemid"];
            int ReceiptUser1 = Convert.ToInt32(ReceiptUser);
            CustomersDTO MyObj = _dataAccess.GetCustomerById(ReceiptUser1);
            if (MyObj.Id == ReceiptUser1)
            {
                foreach (var item in ShoppingCartItem)
                {
                    MyObj.receipt += $";{Convert.ToString(item.ProdId)}";

                }
                _dataAccess.SaveCustomer(MyObj);
            }
        }
    }
}

