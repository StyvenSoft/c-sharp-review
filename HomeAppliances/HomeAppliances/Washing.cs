using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliances
{
    class Washing : Electrodomestics
    {
        private int load = 5;

        private int Load
        {
            get { return this.load; }
            set { this.load = value; }
        }

        public Washing() { }

        public Washing(float price, double weight) : base(price, weight)
        {

        }

        public Washing(float price, string color, char consumption, double weight, int load) : base(price, color, consumption, weight)
        {
            this.load = load;
        }

        public void finalPrice()
        {
            base.finalPrice();

            if (this.load >= 30)
            {
                base.BasePrice = base.BasePrice + 50;
            }
        }
    }
}
