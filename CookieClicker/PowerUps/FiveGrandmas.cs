using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class FiveGrandmas : PowerUp
    {
        public FiveGrandmas() : base(PowerUpRates.Grandma_CPS * 5, PowerUpRates.Grandma_Cost * 5)
        {

        }

        public override void IncreaseCount()
        {
            CookieGame.GrandmasCount += 5;
        }

    }
}
