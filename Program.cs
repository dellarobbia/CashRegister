/* Cash Register Program

    Performs basic function of presenting user a menu they can order items from

    Written by Andrew McKay
    Last Edited on 4/15/22
 */
using System;
using System.Collections.Generic;
using CashRegister.Menus;
using CashRegister.Items;
using CashRegister.Transactions;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            TransactionMenu transactionMenu = buildTransactionMenu();
            ItemMenu itemMenu = buildItemMenu();
            ITransaction transaction;

            do
            {
                transactionMenu.DisplayMenu();
                switch(transactionMenu.UserSelection)
                {
                    case 1:
                    {
                        transaction = buildSaleTransaction(itemMenu);
                        Console.WriteLine(transaction.Receipt());
                        break;
                    }
                    /*
                    case 2: 
                    {
                        transaction = buildRefundTransaction();
                        Console.WriteLine(transaction.Receipt());
                        break;
                    }
                    */
                    default:
                        Console.WriteLine("Have a nice day!");
                        break;
                }
            } while(transactionMenu.UserSelection != 0);
        }


        //Build Menu Objects
        static TransactionMenu buildTransactionMenu()
        {
            return new TransactionMenu();
        }
        static Menus.ItemMenu buildItemMenu()
        {
            return new ItemMenu(buildMenuItems());
        }

        //Build MenuItems list
        static List<MenuItem> buildMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(new MenuItem("Hamburger", 1.50));
            menuItems.Add(new MenuItem("Chicken Sandwich", 1.75));
            menuItems.Add(new MenuItem("Daily Special", 3.00));
            menuItems.Add(new MenuItem("Fries", 0.75));
            menuItems.Add(new MenuItem("Soft Drink", 1.00));
            menuItems.Add(new MenuItem("Milkshake", 2.00));
            menuItems.Add(new MenuItem("Water", 0.00));

            return menuItems;
        }

        //Build Transaction Objects
        static SaleTransaction buildSaleTransaction(ItemMenu itemMenu)
        {
            List<MenuItem> menuSelections = new List<MenuItem>();
            MenuItem itemSelection;

            do
            {
                itemMenu.DisplayMenu();
                if(itemMenu.UserSelection != 0)
                {
                    itemSelection = itemMenu.MenuItems[itemMenu.UserSelection - 1];
                    menuSelections.Add(itemSelection);
                }
            }while(itemMenu.UserSelection != 0);

            return new SaleTransaction(menuSelections);
        }

        //static RefundTransaction buildRefundTransaction()
    }
}
