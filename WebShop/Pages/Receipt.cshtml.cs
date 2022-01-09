using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.DataAccess;
using WebShop.DTO;

namespace WebShop.Pages
{
    public class ReceiptModel : PageModel
    {
        public readonly IDataAccess _dataaccess;

        public List<CustomersDTO> Customers { get; set; }



        public ReceiptModel(IDataAccess dataAccess)
        {
            _dataaccess = dataAccess;
        }
        public void OnGet()
        {
            if (Customers == null)
            {
                Customers = _dataaccess.GetAllCustomers().ToList();
            }

        }

        public CustomersDTO Customer { get; set; }
        
        [BindProperty]
        public string SearchTerm1 { get; set; }
        public IActionResult OnPostSearch()
        {
            
            if (!string.IsNullOrEmpty(SearchTerm1))
            {
                Customers = _dataaccess.GetAllCustomers().Where(p => p.FirstName.ToLower().Contains(SearchTerm1.ToLower())).ToList();
                return Page();
            }
            return Page();
        }
    }
}
