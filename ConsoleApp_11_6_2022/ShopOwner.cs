using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    public class ShopOwner : Person
    {
        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }

        private string shopName;

        public ShopOwner(string name, decimal money, string shopName)
            : base(name)
        {
            this.shopName = shopName;

        }


    }
}
