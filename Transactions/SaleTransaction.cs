/* Class to create a transaction to handle sales
 *
 */

 using System;
 using System.Collections.Generic;

 namespace CashRegister.Transactions
 {
     public class SaleTransaction : ITransaction
     {
         //Fields
         private List<Items.MenuItem> items;
         private double total;

         //Properties
         public List<Items.MenuItem> Items
         {
             get {return items;}
             set {items = value;}
         }
         public double Total
         {
             get {return total;}
             set {total = value;}
         }

         //Constructor
         public SaleTransaction(List<Items.MenuItem> items)
         {
             Items = items;
         }

        //Interface Methods
         public double CalcTotal()
         {
             long itemCount = items.Count;
             double priceSum = 0;

             for (int i = 0; i <= itemCount - 1; i++)
             {
                 priceSum += items[i].Price;
             }

             return priceSum;
         }

         public String Receipt()
         {
            total = CalcTotal();
            String formatTotal = String.Format("${0:0.##}", total);
            String receipt = "Thank you for dining with us!\n\n";
            long itemCount = items.Count;

            for (int i = 0; i <= itemCount - 1; i++)
            {
                receipt += items[i].ToString() + "\n";
            }

            receipt += "\n\n" +
                "Your total due is " + formatTotal + "\n\n";

            return receipt;
         }
     }
 }