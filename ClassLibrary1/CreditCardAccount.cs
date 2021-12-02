using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CreditCardAccount
    {
        /*
         * 6. Credit Card Account
         *  a. accountNumber - int
         *  b. customerInfo - Customer
         *  c. balance - decimal
         *  d. isPastDue - bool
         *  e. annualInterestRate - decimal
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private int _accountNumber;
        private Customer _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public Customer CustomerInfo
        {
            get { return _customerInfo; }
            set { _customerInfo = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public bool IsPastDue
        {
            get { return _isPastDue; }
            set { _isPastDue = value; }
        }
        public decimal AnnualInterestRate
        {
            get { return _annualInterestRate; }
            set { _annualInterestRate = value; }
        }


        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount() { }

        public override string ToString()
        {
            return string.Format($"Account Number: {AccountNumber}\n" +
                $"{CustomerInfo}\n" +
                $"Balance: {Balance:c}\n" +
                $"{(IsPastDue ? "Is Past Due" : "Is not past due")}\n" +
                $"Annual Interest Rate: {AnnualInterestRate}%");
        }
    }//end class
}//end namespace
