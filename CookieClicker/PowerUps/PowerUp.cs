using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    abstract class PowerUp
    {
        public float ClicksPerSecond { get; set; }
        public float Cost { get; set; }
        public PowerUp(float cps, float cost)
        {
            this.ClicksPerSecond = cps;
            this.Cost = cost;
        }

        public float getCps()
        {
            return this.ClicksPerSecond;
        }

        public float getCost()
        {
            return this.Cost;
        }

        abstract public void IncreaseCount();

        // vvv NOT IN USE vvv
        public String PriceAndCPS()
        {
            return String.Format("{0} = {1:0.00}, CPS: {2}", this.GetType(), this.getCost(), this.getCps());
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
