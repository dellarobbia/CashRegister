/* Class to handle MenuItem selection
 *
 */

 using System;
 using System.Collections.Generic;

 namespace CashRegister.Menus
 {
     public class ItemMenu : IMenu
     {
        //Fields
        private int userSelection;
        private List<Items.MenuItem> menuItems;

        //Properties
        public int UserSelection
        {
            get {return userSelection;}
            set {userSelection = value;}
        }
        public List<Items.MenuItem> MenuItems
        {
            get {return menuItems;}
            set {menuItems = value;}
        }

        //Constructor
        public ItemMenu(List<Items.MenuItem> menuItems)
        {
            MenuItems = menuItems;
        }

        //Interface Methods
        public void DisplayMenu()
        {
            Console.Write(menuString());
            GetUserSelection();
        }
        public int GetUserSelection()
        {
            return int.Parse(Console.ReadLine());
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
     }
 }