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
        Graphics g { get; set; }

        public Form1()
        {
            InitializeComponent();

            // doubleBuffered true & new Graphics from current tab
            this.DoubleBuffered = true;
            this.g = pictureBox1.CreateGraphics();

            // create CookieGame object
            Cookie cookie = new Cookie();
            cookieGame = new CookieGame(cookie, this.g);
            cookieGame.StartGame();
            Invalidate(true);
            pictureBox1.Image = Properties.Resources.cookie1_transparent;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            lbPlusCookie.Parent = pictureBox1;
            lbPlusCookie.BackColor = Color.Transparent;
        }


        public void ClickCookie() 
        {
            cookieGame.ClickCookie();
            UpdateCookiesLabel();
            CheckEnabled();
            // todo: Show +1 Cookie! toast notification
            Rectangle cookieRectangle = cookieGame.Cookie.rectangle;
            lbPlusCookie.Visible = false;

            Random rnd = new Random();

            int rndX = rnd.Next(cookieRectangle.X, cookieRectangle.X + cookieRectangle.Width);
            int rndY = rnd.Next(cookieRectangle.Y, cookieRectangle.Y + cookieRectangle.Height);

            Point randomPt = new Point(rndX, rndY);
            lbPlusCookie.Location = randomPt;
            lbPlusCookie.Visible = true;

            cookieGame.DrawCookieDown();
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



        private void tabGame_MouseClick(object sender, MouseEventArgs e)
        {
            if(cookieGame.Cookie.IsCookiePressed(e.Location))
                this.cookieGame.DrawCookieDown();
            ClickCookie();
        }


        private void tabGame_MouseUp(object sender, MouseEventArgs e)
        {
            this.cookieGame.DrawCookieUp();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // set background
            tabGame.BackgroundImage = Properties.Resources.bluePattern1;
        }

    }
}
