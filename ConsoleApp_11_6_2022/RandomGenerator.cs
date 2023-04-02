using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    /// <summary>
    /// Generates random guitars and guitar shops.
    /// </summary>
    public static class RandomGenerator
    {
        private static Random random = new Random();

        public static string GetRandomOwner()
        {
            string ownerName;
            int randomNumber = random.Next(4);

            if (randomNumber == 0)
            {
                ownerName = "Zach";
            }
            else if (randomNumber == 1)
            {
                ownerName = "Taylor";
            }
            else if (randomNumber == 2)
            {
                ownerName = "Jacob";
            }
            else
            {
                ownerName = "Chris";
            }

            return ownerName;

        }

        public static Guitar GenerateGuitar()
        {
            Guitar randomGuitar = new Guitar(GetRandomBrand());

            decimal randomPrice = random.Next(100, 1501);
            randomPrice = Math.Round(randomPrice / 10) * 10;
            randomPrice -= 0.01M;
            randomGuitar.Price = randomPrice;
            return randomGuitar;

        }
        public static string GetRandomBrand()
        {
            string guitarBrand;
            int randomBrand = random.Next(4);

            if (randomBrand == 0)
            {
                guitarBrand = "Fender";
            }
            else if (randomBrand == 1)
            {
                guitarBrand = "Taylor";
            }
            else if (randomBrand == 2)
            {
                guitarBrand = "ZachsGuitars";
            }
            else
            {
                guitarBrand = "Squire";
            }

            return guitarBrand;
        }

        public static string GenerateShopName()
        {
            int randomValue = random.Next(1, 5); //1-4

            switch (randomValue)
            {
                case 1: return "Guitarbonaza";
                case 2: return "Zach's Guitars";
                case 3: return "Guitar Center";
                default: return "Guitars4U";
            }
        }


        public static GuitarShop GenerateGuitarShop(int numberOfGuitars = 10)
        {
            string randomOwner = GetRandomOwner();
            decimal ownerMoney = 10000 + (random.Next(1, 11) * 1000);
            string shopName = GenerateShopName();

            ShopOwner owner = new ShopOwner(randomOwner, ownerMoney, shopName);

            GuitarShop newShop = new GuitarShop(owner);

            //This makes numberOfGuitars generated guitars.
            for (int i = 0; i < numberOfGuitars; i++)
            {
                Guitar generatedGuitar = GuitarGenerator.GenerateGuitar();
                newShop.AddGuitar(generatedGuitar);
            }
            return newShop;
        }

    }

}
