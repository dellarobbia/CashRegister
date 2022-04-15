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
            MaxSelection = 2;
            MinSelection = 0;
            MenuString = menuString();
        }

        //Interface Methods

        //Class Mehtods
        private String menuString()
        {
            String menuString = 
                "Select the type of transaction:\n" +
                "0: Exit\n" +
                "1: Sale\n";
            return menuString;
        }
    }
 }