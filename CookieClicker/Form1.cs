using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// todo: 
// change CPS label to show 1 decimal
// add progress bar with "Maximum power" 

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        CookieGame cookieGame { get; set; }

        public Form1()
        {
            InitializeComponent();

            // set background
            this.tabGame.BackgroundImage = Properties.Resources.bluePattern1;

            // doubleBuffered true & new Graphics from current tab
            this.DoubleBuffered = true;

            // create CookieGame object
            Cookie cookie = new Cookie();
            cookieGame = new CookieGame(cookie);
            cookieGame.StartGame();
            Invalidate(true);

            pbCookie.Image = Properties.Resources.cookie1_transparent_small;
            pbCookie.SizeMode = PictureBoxSizeMode.StretchImage;

            lbPlusCookie_1.Parent = pbCookie;
            lbPlusCookie_1.BackColor = Color.Transparent;
        }


        public void ClickCookie() 
        {
            cookieGame.ClickCookie();
            UpdateCookiesLabel();
            CheckEnabled();
            UpdatePlusCookieLabel();
        }

        public void ClickCookieDown()
        {
            pbCookie.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void ClickCookieUp()
        {
            pbCookie.SizeMode = PictureBoxSizeMode.StretchImage;
            ClickCookie();
        }

        public Point GeneratePointForLabel()
        {
            // todo: Show +1 Cookie! toast notification
            Rectangle cookieRectangle = pbCookie.Bounds;
            lbPlusCookie_1.Visible = false;

            Random rnd = new Random();

            int rndX = rnd.Next(0, cookieRectangle.Width - 70);
            int rndY = rnd.Next(0, cookieRectangle.Height - 40);

            // Debug.WriteLine("UpdatePlusCookieLabel: " + cookieRectangle.ToString());
            // Debug.WriteLine("rndX: " + rndX + " rndY: " + rndY);
            return new Point(rndX, rndY);
        }

        public void UpdatePlusCookieLabel()
        {
            Point randomPt = GeneratePointForLabel();


            lbPlusCookie_1.Location = randomPt;
            lbPlusCookie_1.Visible = true;
            
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


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void pbCookie_MouseDown(object sender, MouseEventArgs e)
        {
            ClickCookieDown();
        }

        private void pbCookie_MouseUp(object sender, MouseEventArgs e)
        {
            ClickCookieUp();
        }

        private void timeLabelDisappear_Tick(object sender, EventArgs e)
        { 
             lbPlusCookie_1.Visible = false;
        }

        private void lbPlusCookie_Click(object sender, EventArgs e)
        {
            ClickCookieDown();
        }
    }
}
