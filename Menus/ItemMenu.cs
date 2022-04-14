/* Class to handle MenuItem selection
 *
 */

 using System;
 using System.Collections.Generic;

 namespace CashRegister.Menus
 {
     public class ItemMenu : Menu
     {
        //Fields
        private List<Items.MenuItem> menuItems;
        private Items.MenuItem selection;

        //Properties
        public List<Items.MenuItem> MenuItems
        {
            get {return menuItems;}
            set {menuItems = value;}
        }
        public Items.MenuItem Selection
        {
            get {return selection;}
            set {selection = menuItems[UserSelection - 1];}
        }

        //Constructor
        public ItemMenu(List<Items.MenuItem> menuItems)
        {
            MenuItems = menuItems;
            MenuString = menuString();
            MaxSelection = setMaxSelection();
            MinSelection = 0;
        }

        //Class Methods
        private String menuString()
        {
            int menuNumber = 1;
            int itemCount = menuItems.Count;
            String menuText = 
                "Please order from the menu below:\n\n" + 
                "0: Finish Order\n";

            for (int i = 0; i <= itemCount - 1; i++)
            {
                menuText += menuNumber + ": " + menuItems[i].ToString() + "\n";
                menuNumber++;
            }

            return menuText;
        }
        private int setMaxSelection()
        {
            return menuItems.Count;
        }
     }
 }