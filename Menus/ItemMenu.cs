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

        //Properties
        public List<Items.MenuItem> MenuItems
        {
            get {return menuItems;}
            set {menuItems = value;}
        }

        //Constructor
        public ItemMenu(List<Items.MenuItem> menuItems)
        {
            MenuItems = menuItems;
            MenuString = menuString();
            MaxSelection = setMaxSelection();
            MinSelection = 1;
        }

        //Class Methods
        private String menuString()
        {
            int menuNumber = 1;
            int itemCount = menuItems.Count;
            String menuText = "Please order from the menu below:\n\n";

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