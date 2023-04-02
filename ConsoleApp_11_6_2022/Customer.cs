using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    /// <summary>
    /// Defines an object that represents a customer for a <see cref="GuitarShop"/> who can spend money and own <see cref="Guitar"/>s.
    /// </summary>
    public class Customer : Person
    {

        private List<Guitar> guitars = new List<Guitar>();

        public Customer(string name, decimal money)
            : base(name)
        {
            this.money = money;
        }

        public void AddGuitar(Guitar guitar)
        {
            guitars.Add(guitar);
        }

        public void RemoveGuitar(Guitar guitar)
        {
            guitars.Remove(guitar);
        }

        public List<Guitar> GetGuitars()
        {
            return guitars;
        }

    }
}
