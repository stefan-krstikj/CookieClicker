using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// todo: 
// change CPS label to show 1 decimal

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        CookieGame cookieGame { get; set; }

        public Form1()
        {
            InitializeComponent();
            Cookie cookie = new Cookie();
            cookieGame = new CookieGame(cookie);
            Invalidate(true);
            tabGame.BackgroundImage = Properties.Resources.bluePattern1;
            this.DoubleBuffered = true;
        }

        public void ClickCookie()
        {
            cookieGame.ClickCookie();
            UpdateCookiesLabel();
            CheckEnabled();
        }

        public void UpdateFingerLabel()
        {
            this.lbFingers.Text = String.Format("Fingers: {0}", cookieGame.Fingers);
        }

        public void UpdateGrandmaLabel()
        {
            this.lbGrandmas.Text = String.Format("Grandmas: {0}", cookieGame.Grandmas);

        }

        public void UpdateRobotLabel()
        {
            this.lbRobots.Text = String.Format("Robots: {0}", cookieGame.Grandmas);
        }

        public void UpdateCookiesLabel()
        {
            this.lbCookies.Text = String.Format("Cookies: {0}", cookieGame.CookiesCount);
        }

        public void UpdateCPSLabel()
        {
            this.lbCPS.Text = String.Format("Cookies Per Second: {0}", cookieGame.ClicksPerSecond);
        }

        public void UpdateLabels()
        {
            this.UpdateCookiesLabel();
            this.UpdateCPSLabel();
            this.UpdateFingerLabel();
            this.UpdateGrandmaLabel();
            this.UpdateRobotLabel();
        }

        public void Start()
        {
            CheckEnabled();
            UpdateLabels();
            this.btnBuyGrandma.Text = String.Format("Grandma = {0}", Constants.GRANDMA_COST);
            this.btnBuyRobot.Text = String.Format("Robot = {0}", Constants.ROBOT_COST);
            this.btnBuyFinger.Text = String.Format("Finger = {0}", Constants.FINGER_COST);
            timeCookiePerSecond.Start();
            tabControl.SelectedTab = tabGame;
        }

        public void Quit()
        {
            this.Close();
        }

        public void CheckEnabled()
        {
            // todo: Check if we have enough cookies to buy Finger / Grandma
            if (cookieGame.CookiesCount < Constants.GRANDMA_COST)
                btnBuyGrandma.Enabled = false;
            else
                btnBuyGrandma.Enabled = true;


            if (cookieGame.CookiesCount < Constants.FINGER_COST)
                btnBuyFinger.Enabled = false;
            else
                btnBuyFinger.Enabled = true;

            if (cookieGame.CookiesCount < Constants.ROBOT_COST)
                btnBuyRobot.Enabled = false;
            else
                btnBuyRobot.Enabled = true;
        }


        private void btnCookieClick_Click(object sender, EventArgs e)
        {
            ClickCookie();
        }

        private void timeCookiePerSecond_Tick(object sender, EventArgs e)
        {
            cookieGame.UpdateCookies();
            UpdateLabels();
            CheckEnabled();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Start();
        }

        public void AddFinger()
        {
            cookieGame.AddPowerUp(new Finger());
            UpdateLabels();
            CheckEnabled();
        }

        public void AddGrandma()
        {
            cookieGame.AddPowerUp(new Grandma());
            CheckEnabled();
            UpdateLabels();
        }

        private void btnBuyFinger_Click(object sender, EventArgs e)
        {
            AddFinger();
        }

        private void btnBuyGrandma_Click(object sender, EventArgs e)
        {
            AddGrandma();
        }

        private void tabGame_Paint(object sender, PaintEventArgs e)
        {
            this.cookieGame.DrawCookie(e.Graphics);
        }


    }
}
