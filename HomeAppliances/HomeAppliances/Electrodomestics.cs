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
            set {
                this.color = value.ToLower();
                this.checkColor(this.color);
            }
        }

        public char EnergyConsumption
        {
            get { return this.energyConsumption; }
            set {
                this.energyConsumption = Convert.ToChar(value.ToString().ToLower());
                this.checkEnergyConsumption(this.energyConsumption);
            }
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
            this.color = color.ToLower();
            this.energyConsumption = Convert.ToChar(energyConsumption.ToString().ToLower());
            this.weight = weight;
            this.checkEnergyConsumption(this.energyConsumption);
            this.checkColor(this.color);
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
                    break;
                }
                if (!find)
                {
                    this.energyConsumption = 'F';
                }
            }
        }

        public void checkColor(string color)
        {
            string[] colores = { "white", "black", "red", "blue", "gray" };
            bool find = false;

            for (int i = 0; i < colores.Length; i++)
            {
                if (color == colores[i])
                {
                    find = true;
                    break;
                }
                if (!find)
                {
                    this.color = "white";
                }
            }
        }

        public virtual void finalPrice()
        {
            switch (this.energyConsumption)
            {
                case 'A':
                    this.basePrice = 100;
                    break;
                case 'B':
                    this.basePrice = 80;
                    break;
                case 'C':
                    this.basePrice = 60;
                    break;
                case 'D':
                    this.basePrice = 50;
                    break;
                case 'E':
                    this.basePrice = 30;
                    break;
                case 'F':
                    this.basePrice = 10;
                    break;
            }

            if (this.weight > 0 && this.weight <= 19)
            {
                this.basePrice += 10;
            } else if (this.weight >= 20 && this.weight <= 49)
            {
                this.basePrice += 50;
            } else if (this.weight >= 50 && this.weight <= 79)
            {
                this.basePrice += 80;
            }else
            {
                this.basePrice += 100;
            }
        }
    }
}
