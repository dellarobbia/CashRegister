/* Class to handle refund transactions
 *
 */

 using System;

 namespace CashRegister.Transactions
 {
     public class RefundTransaction : ITransaction
     {
         //Fields
         private double amount;

         //Properties
         public double Amount
         {
            get {return amount;}
            set {amount = value;}
         }

         //Constructor
         public RefundTransaction(double amount)
         {
            Amount = amount;
         }

         //Interface Methods
         public double CalcTotal()
         {
             return amount;
         }
         public String Receipt()
         {
             String formatAmount = String.Format("${0:0.##}", amount);

             return "The amount of " + formatAmount + " has been refunded.";
         }
        public void PrintReceipt()
        {
            //todo: build refund receipt printer
        }
     }
 }