Mortgage Calculator: Coding Challenge
You have been asked to build an application to help users calculate their amortized loan repayment schedule. The application must be responsive, easy to use, and calculate the user's loan correctly based on their input. 

Functional Requirements

Write a mortgage loan calculator that takes in three parameters:

The amount of money loaned in dollars (balance)

The time over which the loan will be repaid, in months (term)

The annual percentage rate at which interest will accrue on the loan (rate)

The output should include the following for each month of the loan:

The month (1 corresponding to the 1st month of payment, through the total number of months)

The payment amount

The principal paid this month

The interest paid this month

The total interest paid to date

The remaining balance at the end of the month

Additionally, the application should also display a loan summary including the following:

The total monthly payment of the loan

The total principal balance borrowed

The total interest paid through the lifetime of the loan

The total cost of the loan after it has been repaid

Technical Requirements

The project must meet the following criteria

Built with Blazor, HTML, CSS, and Bootstrap. The UI must be responsive across all screen sizes.

Code must reside in a GitHub repo

The finished project must be published to Netlify

UI Mockup

Note: the numbers pictured above are accurate, so they can be used to verify your calculations are correct

Formulas Used

Total Monthly Payment = (amount loaned) * (rate / 1200) / ( 1 - (1 + rate/1200)^(-Number of Months) )

Before the very first month, Remaining Balance = the amount of the loan

Interest Payment = Previous Remaining Balance * rate/1200

Principal Payment = Total Monthly Payment - Interest Payment

At the end of each month, Remaining Balance = Previous Remaining Balance - Principal Payment

Grading Criteria

Does the project meet specifications?

Does the app exceed specifications?

Is the UI responsive & attractive?

Ease of Use/Intuitive

Are inputs validated?

Overall Presentation