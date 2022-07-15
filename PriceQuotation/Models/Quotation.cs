using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class Quotation
    {
        [Required(ErrorMessage = "Please enter a subtotal.")]
        [Range(1, 500000, ErrorMessage = "Subtotal amount must be greater than 1")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percentage.")]
        [Range(0, 100, ErrorMessage = "Discount amount must be between .01 and 100")]
        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }
        public decimal? Total { get; set; }
        public decimal? GetDiscountAmount ()
        {
            DiscountAmount = this.Subtotal / this.DiscountPercent;
            return DiscountAmount;
        }
        public decimal? GetTotalAmount()
        {
            Total = this.Subtotal - this.GetDiscountAmount();
            return Total;
        }
    }
}
