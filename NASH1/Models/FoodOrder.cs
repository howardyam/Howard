using System.ComponentModel.DataAnnotations;

namespace NASH1.Models
{
    public class FoodOrder
    {

        [Key]
        public int Order_Id { get; set; }

        public string OrderedFood { get; set; }

        public float FoodPrice  {get; set;}

         
        public int Amount { get; set;}

        public float TotalPrice { get; set;}


    }
}
