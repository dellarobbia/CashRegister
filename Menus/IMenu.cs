/* Interface to define menu fucntions
 *
 */

 using System;

 namespace CashRegister.Menus
 {
     public interface IMenu
     {
         public void DisplayMenu();
         public int GetUserSelection();
     }
 }