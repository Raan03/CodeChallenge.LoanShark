using CodeChallenge.LoanShark.Models;

namespace CodeChallenge.LoanShark.Helpers
{
    public static class LoanUtilities
    {
        /// <summary>
        /// Calculates and returns updated payment information for the specified loan.
        /// </summary>
        /// <param name="loan">The loan model containing loan details.</param>
        /// <returns>A LoanModel instance with updated payment information.</returns>
        public static LoanModel GetPayments(LoanModel loan)
        {
            loan.Payments.Clear();

            // calculate the monthly payment using the loan amount, rate, and term
            loan.Payment = CalculatePayment(loan.PurchaseAmount, loan.Rate, loan.Term);

            int loanMonths = loan.Term * 12;
            // variables to hold the total interest and total cost of the loan
            double balance = loan.PurchaseAmount;
            double totalInterest = 0;
            double monthlyPrincipal = 0;
            double monthlyInterest = 0;
            double monthlyInterestRate = CalculateMonthlyRate(loan.Rate);

            for(int month = 1; month <= loanMonths; month++)
            {
                monthlyInterest = CalculateMonthlyInterest(balance, monthlyInterestRate);
                totalInterest += monthlyInterest;
                monthlyPrincipal = loan.Payment - monthlyInterest;
                balance -= monthlyPrincipal;

                LoanPaymentModel payment = new LoanPaymentModel
                {
                    Month = month,
                    Payment = loan.Payment,
                    MonthlyPrincipal = monthlyPrincipal,
                    MonthlyInterest = monthlyInterest,
                    TotalInterest = totalInterest,
                    Balance = balance > 0 ? balance : 0
                };

                loan.Payments.Add(payment);
            }

            loan.TotalInterest = totalInterest;
            loan.TotalCost = loan.PurchaseAmount + totalInterest;

            return loan;
        }
        /// <summary>
        /// Calculates the total monthly payment for a loan based on the loan amount, annual percentage rate (APR), and
        /// loan term in months.
        /// </summary>
        /// <param name="amount">The principal loan amount.</param>
        /// <param name="rate">The annual percentage rate (APR) as a percentage.</param>
        /// <param name="term">The loan term in months.</param>
        /// <returns>The calculated monthly payment amount.</returns>
        // formula: Total Monthly Payment = (Loan Amount * (APR / 1200)) / (1 - (1 + (APR / 1200)) ^ -Term)
        public static double CalculatePayment(double amount, double rate, int term)
        {
            var monthlyRate = CalculateMonthlyRate(rate);
            var months = term * 12;
            var payment = (amount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -months));

            return payment;
        }

        private static double CalculateMonthlyRate(double rate)
        {
            return rate / 1200;
        }

        public static double CalculateMonthlyInterest(double balance, double monthlyRate)
        {
            return balance * monthlyRate;
        }
    }
}
