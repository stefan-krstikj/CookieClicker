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

        public static long FingersCount { get; set; }
        public static long GrandmasCount { get; set; }
        public static long RobotsCount { get; set; }
        public long TotalClicksCount { get; set; }
        public long TotalCookiesCount { get; set; }

        public CookieGame(Cookie cookie)
        {
            this.Cookie = cookie;
            powerUps = new List<PowerUp>();
            StartGame();
        }

        /// <summary>
        /// Increase CookiesCount
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
            CookiesCount += (int)ClicksPerSecond;
        }

        /// <summary>
        /// Start the Game
        /// <para>Reset counters to 0</para>
        /// </summary>
        public void StartGame()
        {
            ClicksPerSecond = Constants.CLICKS_PER_SECOND;
            CookiesCount = 0;
            FingersCount = 0;
            GrandmasCount = 0;
            RobotsCount = 0;
        }

        /// <summary>
        /// Update current Cookie Count after PowerUp purchase
        /// </summary>
        /// <param name="powerUp"></param>
        public void UpdateCounts(PowerUp powerUp)
        {
            CookiesCount -= (long)powerUp.getCost();
            powerUp.IncreaseCount();
            if (powerUp is Finger)
            {
                PowerUpRates.UpdateFingerCosts();
            }

            else if (powerUp is Grandma)
            {
                PowerUpRates.UpdateGrandmaCosts();
            }

            else if (powerUp is Robot)
            {
                PowerUpRates.UpdateRobotCosts();
            }

            // Gala code
            else if (powerUp is FiveFingers)
            {
                PowerUpRates.UpdateFiveFingersCosts();

            }

            else if (powerUp is FiveGrandmas)
            {
                PowerUpRates.UpdateFiveGrandmasCosts();

            }

            else if (powerUp is FiveRobots)
            {
                PowerUpRates.UpdateFiveRobotsCosts();

            }


        }


        /// <summary>
        /// Add a PowerUp to the game
        /// </summary>
        /// <param name="powerUp"></param>
        public void AddPowerUp(PowerUp powerUp)
        {
            Debug.Write("Adding powerup... " + powerUp.ToString() + " With CPS: " + powerUp.ClicksPerSecond + " And cost: " + powerUp.Cost + " \n");
            this.powerUps.Add(powerUp);
            UpdateCounts(powerUp);
            IncreaseClicksPerSecond(powerUp.ClicksPerSecond);
        }
    }
}
