using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022
{
    public class Guitar
    {

        /// <summary>
        /// Gets or sets the price of the guitar.
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        //Body

        //Neck

        //Head - Where strings attach

        private int numberOfStrings = 6;

        /// <summary>
        /// The length of the neck, recorded in inches
        /// </summary>
        private double lengthOfNeck = 24;

        private int numberOfFrets = 22;

        private double weight = 8.5;

        private string brand;

        private decimal price;

        //Constructors - Are the starting 'method'
        //structure of a constructor: [scope] Guitar(parameters)

        public Guitar(string brandOfGuitar)
        {
            brand = brandOfGuitar;
        }

        public void SetNumberOfStrings(int newStringCount)
        {
            numberOfStrings = newStringCount;
        }

        public int GetNumberOfStrings()
        {
            return numberOfStrings;
        }

        public void SetLengthOfNeck(double newLengthOfNeck)
        {
            lengthOfNeck = newLengthOfNeck;
        }

        public double GetLengthOfNeck()
        {
            return lengthOfNeck;
        }

        public void SetNumberOfFrets(int newFretCount)
        {
            numberOfFrets = newFretCount;
        }

        public int GetNumberOfFrets()
        {
            return numberOfFrets;
        }

        public void SetWeight(double newWeight)
        {
            weight = newWeight;
        }

        public double GetWeight()
        {
            return weight;
        }

        public string GetBrand()
        {
            return brand;
        }

        public string GetDisplayString()
        {
            return $"Brand: {brand} | Price: ${price}";
        }
    }
}