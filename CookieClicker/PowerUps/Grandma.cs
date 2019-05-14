using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class Grandma : PowerUp
    {
         public Grandma() : base(Constants.GRANDMA_CPS, Constants.GRANDMA_COST)
        {

        }

        public override string ToString()
        {
            return "Grandma, CPS: " + base.ClicksPerSecond + " COST: "+base.Cost;
        }
    }
}
