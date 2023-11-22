using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Backend
{
    public class Order
    {
        public string[] menuEntree = { "Chicken Salad", "Ham and Cheese", "Turkey", "Vegetable Wrap" };
        private decimal[] menuEntreePrice = { 5.00m, 4.50m, 4.50m, 3.50m };

        public string entree = "";
        public bool waterSelection;
        public string drinkSelection = "";
        public string specialRequest = "";
        public decimal entreePrice;
        public decimal drinkPrice;

        public decimal DetermineTotalCharges()
        {
            return entreePrice + drinkPrice;
        }

        public string getWaterSelection()
        {
            if (waterSelection) return "Water";
            else return "No water";
        }
        
        public void SetDrinkPrice(string drinkSelection)
        {
            switch (drinkSelection)
            {
                case "Tea":
                case "Coffee":
                    drinkPrice = 1.50m;
                    break;
                case "Soda":
                case "Lemonade":
                    drinkPrice = 2.00m;
                    break;
                case "Milk":
                case "Juice":
                    drinkPrice = 1.75m;
                    break;
            }
        }

        public void SetEntreePrice(string entree)
        {
            for (int i = 0; i < menuEntree.Length; i++)
            {
                if (entree == menuEntree[i])
                {
                    entreePrice += menuEntreePrice[i];
                }
            }
        }
    }
}
