/* Class to represent items that can be ordered off a menu
 *
 */

 using System;

 namespace CashRegister.Items
 {
     public class MenuItem
     {
         //Fields
         private String name;
         private double price;

         //Properties
         public String Name
         {
             get {return name;}
             set {name = value;}
         }
         public double Price
         {
             get {return price;}
             set {price = value;}
         }

         //Constructor
         public MenuItem(string name, double price)
         {
             Name = name;
             Price = price;
         }

        //ToString override
        public override String ToString()
        {
            //Format price to appear as currency
            String formatPrice = String.Format("${0:0.##}", price);
            
            return name + " -- " + formatPrice;
        }
     }
 }