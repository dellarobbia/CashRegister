/* Class to handle Transaction selection
 *
 */

 using System;

 namespace CashRegister.Menus
 {
    public class TransactionMenu : Menu
    {
        //Constructor
        public TransactionMenu()
        {
            MaxSelection = 3;
            MinSelection = 1;
            MenuString = menuString();
        }

        //Interface Methods

        //Class Mehtods
        private String menuString()
        {
            String menuString = 
                "Select the type of transaction:\n" +
                "1: Sale\n" +
                "2: Refund\n" + 
                "3: Exit\n";
            return menuString;
        }
    }
 }