/* Interface to define the actions all Transactions must be able to do
 * 
 */

 namespace CashRegister.Transactions
 {
     public interface ITransaction
     {
         public double CalcTotal();
         public void DispReceipt();
     }
 }