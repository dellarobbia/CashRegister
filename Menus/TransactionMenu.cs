/* Class to handle Transaction selection
 *
 */

 using System;

 namespace CashRegister.Menus
 {
    public class TransactionMenu : IMenu
    {
        //Fields
        private int userSelection;

        //Properties
        public int UserSelection
        {
            get{return userSelection;}
            set{userSelection = value;}
        }

        //Constructor
        public TransactionMenu()
        {
            //null
        }

        //Interface Methods
        public void DisplayMenu()
        {
            Console.Write(MenuString());
            GetUserSelection();
        }
        public int GetUserSelection()
        {
            return int.Parse(Console.ReadLine());
        }

        //Class Mehtods
        private String MenuString()
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