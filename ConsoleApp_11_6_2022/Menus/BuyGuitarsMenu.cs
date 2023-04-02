using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022.Menus
{
    public class BuyGuitarsMenu : Menu
    {
        private GuitarShop shop;
        private Customer customer;

        public BuyGuitarsMenu(GuitarShop shop, Customer customer)
            : base()
        {
            this.shop = shop;
            this.customer = customer;

            CreateOptions();
        }

        private void CreateOptions()
        {
            AddOption("Return", 1);

            List<Guitar> guitars = shop.GetGuitarStock();
            int optionNumber = 2;
            string guitarDisplayString;
            for (int i = 0; i < guitars.Count; i++)
            {
                guitarDisplayString = guitars[i].GetDisplayString();

                AddOption(guitarDisplayString, optionNumber);

                optionNumber++;
            }
        }

        public override string CreateMessage()
        {
            return "Please select a number to purchase the guitar, or type 1 to return.";
        }

        public override MenuList CheckInput(int input, out string message)
        {
            message = "";

            if (input == 1)
            {
                return MenuList.MainMenu;
            }
            else
            {
                int inputIndex = input - 2;

                if (inputIndex < 0)
                {
                    return MenuList.BadInput;
                }

                List<Guitar> guitars = shop.GetGuitarStock();

                if (inputIndex >= guitars.Count)
                {
                    return MenuList.BadInput;
                }

                Guitar guitarToBuy = guitars[inputIndex];

                if (guitarToBuy.Price > customer.Money)
                {
                    message = "You do not have enough money.";
                    return MenuList.None;
                }
                else
                {
                    customer.AddGuitar(guitarToBuy);
                    shop.RemoveGuitar(guitarToBuy);

                    customer.Money -= guitarToBuy.Price;

                    RemoveAllOptions();
                    CreateOptions();
                }
            }

            return base.CheckInput(input, out message);
        }

    }
}
