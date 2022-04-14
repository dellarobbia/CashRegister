/* Menu Superclass to handle displaying prompts and obtaining selections from users
 *
 */

using System;

namespace CashRegister.Menus
{
    public class Menu : IMenu
    {
        //Fields
        private int userSelection = 0;
        private String menuString;
        private int maxSelection;
        private int minSelection;

        //Properties
        public int UserSelection
        {
            get {return userSelection;}
            set {userSelection = value;}
        }
        public String MenuString{
            get {return menuString;}
            set {menuString = value;}
        }
        public int MaxSelection
        {
            get {return maxSelection;}
            set {maxSelection = value;}
        }
        public int MinSelection
        {
            get {return minSelection;}
            set {minSelection = value;}
        }

        //Constructor
        public Menu()
        {
            //null
        }
        public Menu(String menuString)
        {
            MenuString = menuString;
            MaxSelection = 1;
            MinSelection = 1;
        }
        public Menu(String menuString, int maxSelection, int minSelection)
        {
            MenuString = menuString;
            MaxSelection = maxSelection;
            MinSelection = minSelection;
        }

        //Interface Methods
        public void DisplayMenu()
        {
            do
            {
                Console.WriteLine(MenuString);
                userSelection = GetUserSelection();
            } while (isSelectionValid() == false);
        }
        public int GetUserSelection()
        {
            int selection = 0;

            try
            {
                selection = int.Parse(Console.ReadLine());
            } catch (FormatException)
            {
                selection = -1;
            }

            return selection;
        }

        private Boolean isSelectionValid()
        {
            Boolean isValid = false;

            try
            {
                if(userSelection < minSelection || userSelection > maxSelection)
                    throw new Exceptions.InvalidInputException(DisplayInvalidSelection());
                else
                    isValid = true;
            } catch(Exceptions.InvalidInputException invalidInputE)
            {
                Console.WriteLine(invalidInputE.Message);
                isValid = false;
            }

            return isValid;
        }

        private String DisplayInvalidSelection()
        {
            return "Invalid selection. Please select a positive, whole number between " + minSelection + " and " + maxSelection;
        }
    }
}