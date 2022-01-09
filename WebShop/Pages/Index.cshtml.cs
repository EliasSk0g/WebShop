using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.DataAccess;
using WebShop.DTO;

namespace WebShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDataAccess _dataAccess;

        [BindProperty]
        public string SearchTerm { get; set; }

        public IndexModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public List<ProductsDTO> Items1 { get; set; }
        public List<ProductsDTO> products { get; set; }
        public static CartDTO Cart { get; set; }
        public void OnGet()
        {

            if (products == null)
            {
                products = _dataAccess.GetProducts().ToList();
                Cart = new CartDTO();
            }
        }

        public void OnPostCartAdd()
        {
            OnGet();
            
            
            var item_name = Request.Form["item_name"];
            var item_itemid = Request.Form["item_itemid"];
            var item_price = Request.Form["item_price"];
            var MyObj = new ProductsDTO();
           
            MyObj.Brand = item_name;
            MyObj.Price = Convert.ToInt32(item_price);
            MyObj.ProdId = Convert.ToInt32(item_itemid);
            
            CartModel.ShoppingCartItem.Add(MyObj);
            var MyObjTotalPrice = new ProductsDTO();
            MyObjTotalPrice.PriceTotal += MyObj.Price;
        }
       
        public ActionResult OnPostSearch()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                products = _dataAccess.GetProducts().Where(p => p.Brand.ToLower().Contains(SearchTerm.ToLower())).ToList();
                return Page();
            }
            return RedirectToPage("/Index");
        }
    }

}

  

