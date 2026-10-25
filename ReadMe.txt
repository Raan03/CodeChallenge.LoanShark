Build Loan Shark with Visual Studio

Description: Build a WASM SPA

Written By: Antonio Raynor

Loan Shark is a streamlined, interactive mortgage loan calculator built with Blazor WebAssembly, leveraging the power of .NET to deliver real-time, client-side computations. Designed for clarity and precision, the app offers users an intuitive way to calculate detailed loan repayment schedules based on user-defined inputs.

Application Overview

The Loan Shark app allows users to input three key parameters essential for calculating a loan repayment schedule:

Loan Amount: The total amount borrowed in dollars

Loan Term: The duration of repayment in months

Annual Percentage Rate (APR): The interest rate at which the loan accrues annually

Once submitted, the application computes the amortized monthly payment and provides a detailed month-by-month breakdown. This includes:

The month number in the payment schedule

The fixed monthly payment amount

The portion of that payment applied to principal

The portion applied to interest

Cumulative interest paid to date

The remaining loan balance at the end of each month

In addition to the detailed monthly report, the application generates a Loan Summary that consolidates:

The total monthly payment

The original principal amount

The total interest paid over the life of the loan

The final cost of the loan

Technical Implementation

This application is developed using Blazor WebAssembly, HTML, CSS, and Bootstrap, ensuring a fully responsive layout that adapts seamlessly to all screen sizes and devices. The UI design prioritizes clarity, user-friendly input fields, and formatted output tables for quick comprehension.

The core logic implements amortization formulas such as:

Total Monthly Payment = (Loan Amount * (APR / 1200)) / (1 - (1 + (APR / 1200)) ^ -Term)

For each month:

Interest Payment = Previous Balance × (APR / 1200)

Principal Payment = Total Monthly Payment − Interest Payment

Remaining Balance = Previous Balance − Principal Payment

These formulas ensure precise and reliable calculations that align with financial industry standards.

Deployment and Source Code

Source Code: The complete project resides in a public GitHub repository for version control and collaboration.

Deployment: The application is published and publicly accessible via Netlify, offering a fast, serverless experience.

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