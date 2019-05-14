using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class CookieGame
    {
        public Cookie Cookie { get; set; }
        public float ClicksPerSecond { get; set; }
        public int CookiesCount { get; set; }

        public CookieGame(Cookie cookie)
        {
            this.Cookie = cookie;
            ClicksPerSecond = 0;
            CookiesCount = 0;
        }
          
        // method for on cookie click
        public void ClickCookie()
        {
            ++CookiesCount;
        }

        public void IncreaseClicksPerSecond(int increaseAmount)
        {
            ClicksPerSecond += increaseAmount;
        }

        public void UpdateCookies()
        {
            CookiesCount += (int) ClicksPerSecond;
        }
    }
}
