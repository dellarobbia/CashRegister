/* Interface to define the actions all Transactions must be able to do
 * 
 */

 using System;

 namespace CashRegister.Transactions
 {
     public interface ITransaction
     {
         public double CalcTotal();
         public String Receipt();
     }
 }