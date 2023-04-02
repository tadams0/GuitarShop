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
            decimal priceMultiplier = 1;
            Guitar randomGuitar = new Guitar(GetRandomBrand(out priceMultiplier));

            decimal randomPrice = random.Next(100, 1101) * priceMultiplier;
            randomPrice = Math.Round(randomPrice / 10) * 10;
            randomPrice -= 0.01M;
            randomGuitar.Price = randomPrice;
            return randomGuitar;

        }
        public static string GetRandomBrand(out decimal priceMultiplier)
        {
            priceMultiplier = 1;

            string guitarBrand;
            int randomBrand = random.Next(8);

            switch (randomBrand)
            {
                case 0:
                    guitarBrand = "Fender";
                    priceMultiplier = 1.5M;
                    break;
                case 1:
                    guitarBrand = "Taylor";
                    priceMultiplier = 0.35M;
                    break;
                case 2:
                    guitarBrand = "ZachsGuitars";
                    priceMultiplier = 10M;
                    break;
                case 3:
                    guitarBrand = "Gibson";
                    priceMultiplier = 3M;
                    break;
                case 4:
                    guitarBrand = "Epiphone";
                    priceMultiplier = 0.5M;
                    break;
                case 5:
                    guitarBrand = "Ibanez";
                    priceMultiplier = 1M;
                    break;
                case 6:
                    guitarBrand = "Rickenbacker";
                    priceMultiplier = 5.5M;
                    break;
                default:
                    guitarBrand = "Squire";
                    priceMultiplier = 0.8M;
                    break;
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
                Guitar generatedGuitar = GenerateGuitar();
                newShop.AddGuitar(generatedGuitar);
            }
            return newShop;
        }

    }

}
