using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    public static class GuitarGenerator
    {

        private static Random rand = new Random();

        public static Guitar GenerateGuitar()
        {
            string randomBrand = GetRandomBrand();
            Guitar newGuitar = new Guitar(randomBrand);

            decimal price = rand.Next(20, 750);

            price = Math.Round(price / 10) * 10 - 1;
            price += 0.99M;

            newGuitar.Price = price;

            return newGuitar;
        }

        public static string GetRandomBrand()
        {
            int randomValue = rand.Next(1, 5);

            if (randomValue == 1)
            {
                return "Gibson";
            }
            else if (randomValue == 2)
            {
                return "Fender";
            }
            else if (randomValue == 3)
            {
                return "Taylor";
            }
            else if (randomValue == 4)
            {
                return "Martin";
            }
            else
            {
                return "Yamaha";
            }

        }





    }
}
