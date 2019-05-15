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
        public long TotalClicksCount { get; set; }
        public long TotalCookiesCount { get; set; }

        public CookieGame(Cookie cookie)
        {
            this.Cookie = cookie;
            powerUps = new List<PowerUp>();
            StartGame();
        }
          
        /// <summary>
        /// Increas CookiesCount
        /// </summary>
        public void ClickCookie()
        {
            ++CookiesCount;
        }

        /// <summary>
        /// Increase CPS
        /// </summary>
        /// <param name="increaseAmount"></param>
        public void IncreaseClicksPerSecond(float increaseAmount)
        {
            Debug.WriteLine("Increasing CPS... + {0}", increaseAmount);
            ClicksPerSecond += increaseAmount;
        }

        /// <summary>
        /// Add CPS to current Cookie Count
        /// </summary>
        public void UpdateCookies()
        {
            CookiesCount += (int) ClicksPerSecond;
        }

        /// <summary>
        /// Start the Game
        /// <para>Reset counters to 0</para>
        /// </summary>
        public void StartGame()
        {
            ClicksPerSecond = Constants.CLICKS_PER_SECOND;
            CookiesCount = 0;
            Fingers = 0;
            Grandmas = 0;
            Robots = 0;
        }

        /// <summary>
        /// Update current Cookie Count after PowerUp purchase
        /// </summary>
        /// <param name="powerUp"></param>
        public void UpdateCounts(PowerUp powerUp)
        {
            CookiesCount -= (long)powerUp.getCost();
            if (powerUp is Finger)
            {
                Fingers++;
                PowerUpRates.UpdateFingerCosts();
            }
                
            else if (powerUp is Grandma)
            {
                Grandmas++;
                PowerUpRates.UpdateGrandmaCosts();
            }

            else if (powerUp is Robot)
            {
                Robots++;
                PowerUpRates.UpdateRobotCosts();
            }
             
        }


        /// <summary>
        /// Add a PowerUp to the game
        /// </summary>
        /// <param name="powerUp"></param>
        public void AddPowerUp(PowerUp powerUp)
        {
            Debug.Write("Adding powerup... " + powerUp.ToString() + " With CPS: " + powerUp.ClicksPerSecond +" And cost: " + powerUp.Cost+ " \n");
            this.powerUps.Add(powerUp);
            UpdateCounts(powerUp);
            IncreaseClicksPerSecond(powerUp.ClicksPerSecond);
        }
    }
}
