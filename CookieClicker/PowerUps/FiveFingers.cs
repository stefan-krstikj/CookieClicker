using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{

    class FiveFingers : PowerUp
    {
        public FiveFingers() : base(PowerUpRates.Finger_CPS * 5, PowerUpRates.Finger_Cost * 5)
        {

        }

        public override void IncreaseCount()
        {
            CookieGame.FingersCount += 5;
        }


    }

}
