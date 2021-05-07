using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliances
{
    public class Electrodomestics
    {
        private float basePrice = 100;
        private string color = "white";
        private char energyConsumption = 'F';
        private double weight = 5;

        public float BasePrice
        {
            get { return this.basePrice; }
            set { this.basePrice = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value.ToLower(); }
        }

        public char EnergyConsumption
        {
            get { return this.energyConsumption; }
            set { this.energyConsumption = Convert.ToChar(value.ToString().ToLower()); }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Electrodomestics() { }

        public Electrodomestics(float basePrice, double weight) {
            this.basePrice = basePrice;
            this.weight = weight;
        }

        public Electrodomestics(float basePrice, string color, char energyConsumption, double weight) {
            this.basePrice = basePrice;
            this.color = color;
            this.energyConsumption = energyConsumption;
            this.weight = weight;
        }


        public void checkEnergyConsumption(char letter)
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'F' };
            bool find = false;

            for(int i = 0; i < letters.Length; i++)
            {
                if (letter == letters[i])
                {
                    find = true;
                }
                if (!find)
                {
                    this.energyConsumption = 'F';
                }
            }
        }
    }
}
