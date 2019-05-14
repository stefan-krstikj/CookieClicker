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
        public long Cost { get; set; }
        public PowerUp(float cps, long cost)
        {
            this.ClicksPerSecond = cps;
            this.Cost = cost;
        }

        public float getCps()
        {
            return this.ClicksPerSecond;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
