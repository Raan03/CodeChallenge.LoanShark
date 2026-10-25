namespace CodeChallenge.LoanShark.Helpers
{
    public static class LoanUtilities
    {
        /// <summary>
        /// Calculates the total monthly payment for a loan based on the loan amount, annual percentage rate (APR), and
        /// loan term in months.
        /// </summary>
        /// <param name="amount">The principal loan amount.</param>
        /// <param name="rate">The annual percentage rate (APR) as a percentage.</param>
        /// <param name="term">The loan term in months.</param>
        /// <returns>The calculated monthly payment amount.</returns>
        // formula: Total Monthly Payment = (Loan Amount * (APR / 1200)) / (1 - (1 + (APR / 1200)) ^ -Term)
        public static double CalcPayment(double amount, double rate, int term)
        {
            var monthlyRate = CalcMonthlyRate(rate);
            var months = term * 12;
            var payment = (amount * monthlyRate) / (1 - Math.Pow(1 + monthlyRate, -months));

            return payment;
        }

        private static double CalcMonthlyRate(double rate)
        {
            return rate / 1200;
        }
    }
}
