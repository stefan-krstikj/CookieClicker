using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class Grandma : PowerUp
    {
         public Grandma() : base(PowerUpRates.Grandma_CPS, PowerUpRates.Grandma_Cost)
        {

        }

        public override void IncreaseCount()
        {
            CookieGame.GrandmasCount++;
        }

        public override string ToString()
        {
            return "Grandma, CPS: " + base.ClicksPerSecond + " COST: "+base.Cost;
        }
    }
}
