using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NASH1.Pages.Checkout
{

    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public string ImageTitle { get; set; }





        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FoodName))
            {
                FoodName = "Custom;";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }

    }
}
