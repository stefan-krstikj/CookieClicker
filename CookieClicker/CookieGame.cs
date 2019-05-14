using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;

namespace CookieClicker
{
    class CookieGame
    {
        public Cookie Cookie { get; set; }
        public float ClicksPerSecond { get; set; }
        public long CookiesCount { get; set; }
        public List<PowerUp> powerUps { get; set; }

        public long Fingers { get; set; }
        public long Grandmas { get; set; }
        public long Robots { get; set; }
        public Boolean CookieClickedFlag { get; set; }
        public Graphics g { get; set; }

        public CookieGame(Cookie cookie, Graphics g)
        {

            // todo: change these to 'StartGame'
            this.Cookie = cookie;
            powerUps = new List<PowerUp>();
            this.g = g;
            StartGame();
        }
          
        // method for on cookie click
        public void ClickCookie()
        {
            ++CookiesCount;

        }

        public void DrawCookieDown()
        {
            Cookie.DrawSmall(g);
        }

        public void DrawCookieUp()
        {
            Debug.WriteLine("CookieGame: DrawCookieUp()");
            Cookie.DrawBig(g);
        }

        public void IncreaseClicksPerSecond(float increaseAmount)
        {
            Debug.WriteLine("Increasing CPS... + {0}", increaseAmount);
            ClicksPerSecond += increaseAmount;
        }

        public void UpdateCookies()
        {
            CookiesCount += (int) ClicksPerSecond;
        }

        public void StartGame()
        {
            ClicksPerSecond = Constants.CLICKS_PER_SECOND;
            CookiesCount = 0;
            Fingers = 0;
            Grandmas = 0;
            Robots = 0;
            CookieClickedFlag = false;

        }

        public void UpdateCounts(PowerUp powerUp)
        {
            if (powerUp is Finger)
            {
                CookiesCount -= Constants.FINGER_COST;
                Fingers++;
            }
                
            else if (powerUp is Grandma)
            {
                CookiesCount -= Constants.GRANDMA_COST;
                Grandmas++;
            }

            else if (powerUp is Robot)
            {
                CookiesCount -= Constants.ROBOT_COST;
                Robots++;
            }
             
        }

        public void AddPowerUp(PowerUp powerUp)
        {
            Debug.Write("Adding powerup... " + powerUp.ToString() + " With CPS: " + powerUp.ClicksPerSecond +" And cost: " + powerUp.Cost+ " \n");
            this.powerUps.Add(powerUp);
            UpdateCounts(powerUp);
            IncreaseClicksPerSecond(powerUp.ClicksPerSecond);
        }
    }
}
