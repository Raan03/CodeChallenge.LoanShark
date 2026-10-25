using System.ComponentModel.DataAnnotations;

namespace CodeChallenge.LoanShark.Models
{
    public class LoanModel
    {
        [Range(1, double.MaxValue, ErrorMessage = "Purchase amount must be a positive number.")]
        [Required(ErrorMessage = "Purchase amount is required.")]
        public double PurchaseAmount { get; set; }

        [Range(0.0, 100.0, MinimumIsExclusive = true, ErrorMessage = "Rate must be between 0 and 100.")]
        [Required(ErrorMessage = "Rate is required.")]
        public double Rate { get; set; }

        // Term is expressed in years
        [Range(1, 100, ErrorMessage = "Term must be between 1 and 100 years.")]
        [Required(ErrorMessage = "Term is required.")]
        public int Term { get; set; }

        public double Payment { get; set; }
        public double TotalInterest { get; set; }
        public double TotalCost { get; set; }

        public List<LoanPaymentModel> Payments { get; set; } = new List<LoanPaymentModel>();
    }
}
