using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2123
{
    
    public class Accounts
    {
         int AccNo;
         string CusName;
         string AccType;
         string transactionType;
         double Amt;
         double Bal;

        public Accounts(int Accno, string CusName, string AccType, string transactionType, double Amt) //fields setting using constructor
        {
            this.AccNo = AccNo;
            this.CusName = CusName;
            this.AccType = AccType;
            this.transactionType = transactionType;
            this.Amt = Amt;
            this.Bal = 1000;
        }

        public void Credit(double Amt)
        {
            Bal += Amt;
        }

        public void Debit(double Amt)
        {
            Bal -= Amt;
        }

            public void ShowData() //show data func...
        {
            Console.WriteLine("Enter Account Number:");
            this.AccNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer's Name:");
            this.CusName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            this.AccType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
            this.transactionType = Console.ReadLine();
            Console.WriteLine("Enter Amount:");
            this.Amt = Convert.ToDouble(Console.ReadLine());
            if (transactionType == "d")
            {
                transactionType = "Deposit";
                Bal = Bal + Amt;
            }
            else if (transactionType == "w" && Amt < Bal)
            {
                transactionType = "Withdrawal";
                Bal = Bal - Amt;
            }
            else if (transactionType == "w" && Amt > Bal)
            {
                transactionType = "Transaction is not possible.";
            }
            Console.WriteLine("Account Number:"+AccNo);
            Console.WriteLine("Customer Name:"+CusName);
            Console.WriteLine("Account Type:" +AccType);
            Console.WriteLine("Transaction Type:" +transactionType);
            Console.WriteLine("Amount:"+Amt);
            Console.WriteLine("Balance:"+Bal);
        }
    }
    public class Accounts123
    {
        public static void Main(string[] args)
        {
            Accounts myacc = new Accounts(0938238,"harish","savings","d",20000.00);
            myacc.Credit();
            myacc.Debit();
            myacc.ShowData();
            Console.Read();
        }
    }

}
