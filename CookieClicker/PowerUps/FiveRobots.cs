using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class FiveRobots : PowerUp
    {
        public FiveRobots() : base(PowerUpRates.Robot_CPS * 5, PowerUpRates.Robot_Cost * 5)
        {

        }

        public override void IncreaseCount()
        {
            CookieGame.RobotsCount += 5;
        }
    }
}
