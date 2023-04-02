using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022.Menus
{
    public class MainMenu : Menu
    {

        private GuitarShop shop;

        public MainMenu(GuitarShop shop) 
            : base()
        {

            //Message = shop.GetWelcomeMessage();

            this.shop = shop;

            AddOption("Buy Guitars", 1);
            AddOption("Sell Guitars", 2);
            AddOption("Check Guitars", 3);
            AddOption("Exit", 4);

        }


        public override string CreateMessage()
        {
            return shop.GetWelcomeMessage();
        }

        public override MenuList CheckInput(int input, out string message)
        {
            message = "";

            switch (input)
            {
                case 1: return MenuList.BuyGuitarMenu;
                case 2: return MenuList.SellGuitarMenu;
                case 3: return MenuList.CheckGuitar;
                case 4: return MenuList.Exit;
            }

            return base.CheckInput(input, out message);
        }


    }


}
