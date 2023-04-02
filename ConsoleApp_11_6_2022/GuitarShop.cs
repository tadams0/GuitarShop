using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    /// <summary>
    /// This defines a guitar shop object, where customers can purchase guitars for a price.
    /// </summary>
    public class GuitarShop
    {

        public string OwnerName
        {
            get { return owner.Name; }
            set { owner.Name = value; }
        }

        public string ShopName
        {
            get { return owner.ShopName; }
            set { owner.ShopName = value; }
        }

        private List<Guitar> guitars = new List<Guitar>();

        private ShopOwner owner;

        public GuitarShop(ShopOwner owner)
        {
            this.owner = owner;
        }

        public string GetWelcomeMessage()
        {
            return $"Welcome to {ShopName}. What would you like to do?";
        }

        /// <summary>
        /// If there is a null spot in the guitar array, then fill that first.
        /// <br/>
        /// If there are no null spots left, then grow the array and add the new guitar.
        /// </summary>
        /// <param name="guitar"></param>
        public void AddGuitar(Guitar guitar)
        {
            guitars.Add(guitar);
        }


        public void RemoveGuitar(Guitar guitar)
        {
            guitars.Remove(guitar);
        }

        public void RemoveGuitar(int index)
        {
            guitars.RemoveAt(index);
        }

        public Guitar GetGuitar(int index)
        {
            return guitars[index];
        }


        /// <summary>
        /// Gets the guitars in-stock at this guitar shop.
        /// </summary>
        /// <returns>Returns the array of guitars.</returns>
        public List<Guitar> GetGuitarStock()
        {
            return guitars;
        }

        /// <summary>
        /// Determines if the guitar shop has no elements.
        /// </summary>
        /// <returns>Returns true if the shop only has null values. Returns false otherwise.</returns>
        public bool IsGuitarShopEmpty()
        {
            bool result = guitars.Count == 0;
            return result;
        }


    }
}
