using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class PowerUpRates
    {
        public static float Grandma_Cost = Constants.GRANDMA_COST;
        public static float Grandma_CPS = Constants.GRANDMA_CPS;
        public static float Finger_Cost = Constants.FINGER_COST;
        public static float Finger_CPS = Constants.FINGER_CPS;
        public static float Robot_Cost = Constants.ROBOT_COST;
        public static float Robot_CPS = Constants.ROBOT_CPS;
        // Gala code
        public static float FiveFingers_Cost = Constants.FINGER_COST;
        public static float FiveFingers_CPS = Constants.FINGER_CPS;
        public static float FiveGrandmas_Cost = Constants.GRANDMA_COST;
        public static float FiveGrandmas_CPS = Constants.GRANDMA_CPS;
        public static float FiveRobots_Cost = Constants.ROBOT_COST;
        public static float FiveRobots_CPS = Constants.ROBOT_CPS;


        public static void UpdateFingerCosts()
        {
            Finger_Cost = Finger_Cost * Constants.FINGER_INCREASE_COST;
            Finger_CPS = Finger_CPS * Constants.FINGER_INCREASE_CPS;
        }

        public static void UpdateGrandmaCosts()
        {
            Grandma_Cost = Grandma_Cost * Constants.GRANDMA_INCREASE_COST;
            Grandma_CPS = Grandma_CPS * Constants.GRANDMA_INCREASE_CPS;
        }

        public static void UpdateRobotCosts()
        {
            Robot_Cost = Robot_Cost * Constants.ROBOT_INCREASE_COST;
            Robot_CPS = Robot_CPS * Constants.ROBOT_INCREASE_CPS;
        }
        //gala
        public static void UpdateFiveFingersCosts()
        {
            float sum = 0;
            float cps = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Finger_Cost * Constants.FINGER_INCREASE_COST;
                cps += Finger_CPS * Constants.FINGER_INCREASE_CPS;
                UpdateFingerCosts();
            }

            FiveFingers_Cost = sum;
            FiveFingers_CPS = cps;
        }

        public static void UpdateFiveGrandmasCosts()
        {
            float sum = 0;
            float cps = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Grandma_Cost * Constants.GRANDMA_INCREASE_COST;
                cps += Grandma_CPS * Constants.GRANDMA_INCREASE_CPS;
                UpdateGrandmaCosts();
            }

            FiveGrandmas_Cost = sum;
            FiveGrandmas_CPS = cps;
        }

        public static void UpdateFiveRobotsCosts()
        {
            float sum = 0;
            float cps = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Robot_Cost * Constants.ROBOT_INCREASE_COST;
                cps += Robot_CPS * Constants.ROBOT_INCREASE_CPS;
                UpdateRobotCosts();
            }

            FiveRobots_Cost = sum;
            FiveRobots_CPS = cps;
        }

        public static float getFinger_Cost()
        {
            return Finger_Cost;
        }
        public static float getGrandma_Cost()
        {
            return Grandma_Cost;
        }
        public static float getRobot_Cost()
        {
            return Robot_Cost;
        }

        // Gala code
        public static float getFiveFingers_Cost()
        {
            return FiveFingers_Cost;
        }

        public static float getFiveGrandmas_Cost()
        {
            return FiveGrandmas_Cost;
        }

        public static float getFiveRobots_Cost()
        {
            return FiveRobots_Cost;
        }
    }
}
