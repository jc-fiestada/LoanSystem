using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanSystem.Models;

namespace LoanSystem.Services
{
    class BalanceManager
    {
        public VerifiedUsers Loan(VerifiedUsers UserAccount, string LoanAmount, out bool isInputValid)
        {
            int convertedAmount;
            if (!int.TryParse(LoanAmount, out convertedAmount))
            {
                isInputValid = false;
                return UserAccount;
            }

            if (convertedAmount <= 0)
            {
                isInputValid = false;
                return UserAccount;
            }

            UserAccount.loan_balance += convertedAmount;
            isInputValid = true;
            return UserAccount;

        }

        public VerifiedUsers Pay_loan(VerifiedUsers UserAccount, string PayLoanAmount, out bool isInputValid, out bool NoLoanToPay)
        {
            
            int convertedPayLoanAmount;

            if (!int.TryParse(PayLoanAmount,out convertedPayLoanAmount))
            {
                isInputValid = false;
                NoLoanToPay = false;
                return UserAccount;
            }

            if (convertedPayLoanAmount < 0)
            {
                isInputValid = false;
                NoLoanToPay = false;
                return UserAccount;
            }

            if (UserAccount.loan_balance <= 0)
            {
                NoLoanToPay = true;
                isInputValid = true;
                return UserAccount;
            }

            int total = UserAccount.loan_balance - convertedPayLoanAmount;

            if (total <= 0)
            {
                UserAccount.loan_balance = 0;
                UserAccount.cashed_in_balance += Math.Abs(total);

                isInputValid = true;
                NoLoanToPay = false;
                return UserAccount;
            }

            UserAccount.loan_balance -= convertedPayLoanAmount;

            NoLoanToPay = false;
            isInputValid = true;
            return UserAccount;
        }

        public VerifiedUsers CashIn(VerifiedUsers UserAccount, string CashIn, out bool isValidInput)
        {
            int ConvertedAmount;

            if (!int.TryParse(CashIn, out ConvertedAmount))
            {
                isValidInput = false;
                return UserAccount;
            }

            if (ConvertedAmount <= 0)
            {
                isValidInput = false;
                return UserAccount;
            }


            UserAccount.cashed_in_balance += ConvertedAmount;
            isValidInput = true;
            return UserAccount;


        }
    }
}
