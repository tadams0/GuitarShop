using ConsoleApp_11_6_2022.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    /// <summary>
    /// Organizes logic for running a guitar shop game simulation.
    /// </summary>
    public static class ShopGame
    {
        private static GuitarShop shop;

        private static Customer customer;

        private static Menu currentMenu;

        public static void Start()
        {

            shop = RandomGenerator.GenerateGuitarShop();

            customer = new Customer("Bob", 1000);

            bool running = true;
            MainMenu mainMenu = new MainMenu(shop);
            BuyGuitarsMenu buyMenu = new BuyGuitarsMenu(shop, customer);

            Dictionary<MenuList, Menu> menuMapper = new Dictionary<MenuList, Menu>();
            menuMapper[MenuList.MainMenu] = mainMenu;
            menuMapper[MenuList.BuyGuitarMenu] = buyMenu;

            currentMenu = mainMenu;

            string customMessage = "";
            while (running)
            {
                if (customMessage != "")
                {
                    Console.WriteLine(customMessage);
                }

                DisplayScreen(currentMenu);
                int input = GetInput();

                MenuList nextMenu = currentMenu.CheckInput(input, out customMessage);

                if (nextMenu == MenuList.Exit)
                {
                    running = false;
                }
                else if (nextMenu == MenuList.BadInput)
                {
                    Console.WriteLine("That input was not valid. Please try again.");
                }
                else if (nextMenu != MenuList.None)
                {
                    currentMenu = menuMapper[nextMenu];
                }

                MainLogic(input);
            }

        }

        public static void DisplayScreen(Menu menu)
        {
            menu.WriteMessage();

            menu.WriteOptions();

            Console.WriteLine("Please type a number.");
        }

        public static int GetInput()
        {
            bool invalidInput = true;

            while (invalidInput)
            {

                string input = Console.ReadLine();

                int value;
                invalidInput = !int.TryParse(input, out value);

                if (invalidInput)
                {
                    Console.WriteLine("That was an invalid input. Please type a number.");
                }
                else
                {
                    return value;
                }

            }

            return 0;
        }

        public static void MainLogic(int input)
        {

        }



    }
    
}
