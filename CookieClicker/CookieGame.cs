using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

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

        public CookieGame(Cookie cookie)
        {

            // todo: change these to 'StartGame'
            this.Cookie = cookie;
            ClicksPerSecond = 1;
            CookiesCount = 0;
            Fingers = 0;
            Grandmas = 0;
            Robots = 0;
            powerUps = new List<PowerUp>();
        }
          
        // method for on cookie click
        public void ClickCookie()
        {
            ++CookiesCount;
        }

        public void DrawCookie(Graphics g)
        {
            Cookie.Draw(g);
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
