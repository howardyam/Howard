using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NASH1.Models;

namespace NASH1.Pages.Restaurant
{
    
   

        public class KFCModel : PageModel
        {


            [BindProperty]
            public FoodModel Food { get; set; }
            public double FoodPrice { get; set; }
            public void OnGet()
            {
            }

            public IActionResult OnPost()
            {
                FoodPrice = Food.BasePrice;
                FoodPrice += (Food.KFCBurger * 10.2);
                FoodPrice += (Food.KFCWedges * 20.3);
                FoodPrice += (Food.KFChicken * 30.4);

                return RedirectToPage("/Checkout/Checkout", new {Food.FoodName, FoodPrice });
            }
        
    }
}
