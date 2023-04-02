using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    public class Person
    {
        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected decimal money = 0;
        protected string name;

        protected decimal age = 20;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, decimal money)
        {
            this.name = name;
            this.money = money;
        }


    }
}
