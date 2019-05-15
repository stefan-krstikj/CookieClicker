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


        public static void UpdateFingerCosts()
        {
            Finger_Cost = Finger_Cost * Constants.FINGER_INCREASE;
            Finger_CPS = Finger_CPS * Constants.FINGER_INCREASE;
        }

        public static void UpdateGrandmaCosts()
        {
            Grandma_Cost = Grandma_Cost * Constants.GRANDMA_INCREASE;
            Grandma_CPS = Grandma_CPS * Constants.GRANDMA_INCREASE;
        }

        public static void UpdateRobotCosts()
        {
            Robot_Cost = Robot_Cost * Constants.ROBOT_INCREASE;
            Robot_CPS = Robot_CPS * Constants.ROBOT_INCREASE;
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
    }
}
