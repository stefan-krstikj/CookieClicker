using System;
using System.Drawing;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        CookieGame cookieGame { get; set; }

        private FallDoc fallDoc;
        private int generateFall;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            fallDoc = new FallDoc();
            generateFall = 0;
            random = new Random();

            // set background
            panel1.ForeColor = Color.White;
            this.tabMenu.BackColor = Color.FromArgb(57, 89, 130);


            this.DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CreateCookie();

        }


        public void CreateCookie()
        {
            Cookie cookie = new Cookie();
            cookieGame = new CookieGame(cookie);
            cookieGame.StartGame();
            Invalidate(true);

            pbCookie.Image = Properties.Resources.cookie1_transparent_small;
            pbCookie.SizeMode = PictureBoxSizeMode.StretchImage;

            // set needed label info for transparency
            lbPlusCookie_1.Parent = pbCookie;
            lbPlusCookie_1.BackColor = Color.Transparent;
        }

        // generate falling cookie
        void timerFall_Tick(object sender, EventArgs e)
        {
            int module = 10;

            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 2)
                module = 8;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 5)
                module = 5;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 7)
                module = 3;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 10)
                module = 2;
            if (Math.Ceiling(cookieGame.ClicksPerSecond) > 30)
                module = 1;
            if (generateFall % module == 0)
            {
                int x = random.Next(2 * Fall.RADIUS, Width - (Fall.RADIUS * 2));
                int y = -Fall.RADIUS;
                fallDoc.AddFall(new Point(x, y));
            }

            ++generateFall;
            fallDoc.Move(Width);
            Invalidate(true);
        }


        /// <summary>
        /// Register a Cookie Click
        /// <para>+1 cookie</para>
        /// </summary>
        public void ClickCookie()
        {
            // inform cookieGame object that cookie is clicked
            cookieGame.ClickCookie();

            // update labels
            UpdateCookiesLabel();
            UpdatePlusCookieLabel();

            // check if we have enough cookies, to enable / disable buy buttons
            CheckEnabled();
        }

        /// <summary>
        /// Cookie Clicked Down effect
        /// <para>Changes the PictureBox SizeMode to Zoom</para>
        /// </summary>
        public void ClickCookieDown()
        {
            // Changing the Picture Box SizeMode gives a 'click' effect
            pbCookie.SizeMode = PictureBoxSizeMode.Zoom;
        }


        /// <summary>
        /// Cookie Clicked Up effect
        /// <para>Changes the PictureBox SizeMode to StretchImage</para>
        /// </summary>
        public void ClickCookieUp()
        {
            pbCookie.SizeMode = PictureBoxSizeMode.StretchImage;
            ClickCookie();
        }

        /// <summary>
        /// Generates a Random Point location in the range of the PictureBox Rectangle
        /// </summary>
        /// <returns></returns>
        public Point GeneratePointForLabel()
        {
            // todo: Show +1 Cookie! toast notification
            Rectangle cookieRectangle = pbCookie.Bounds;
            lbPlusCookie_1.Visible = false;

            Random rnd = new Random();

            int rndX = rnd.Next(0, cookieRectangle.Width - 70);
            int rndY = rnd.Next(0, cookieRectangle.Height - 40);

            return new Point(rndX, rndY);
        }

        /// <summary>
        /// Update the "+1 Cookie!" label that shows on top of the Cookie when clicked
        /// </summary>
        public void UpdatePlusCookieLabel()
        {
            Point randomPt = GeneratePointForLabel();


            lbPlusCookie_1.Location = randomPt;
            lbPlusCookie_1.Visible = true;

        }

        /// <summary>
        /// Update the Label for number of Fingers owned
        /// </summary>
        public void UpdateFingerLabel()
        {
            this.lbFingers.Text = String.Format("Fingers: {0}", CookieGame.FingersCount);
            this.btnBuyFinger.Text = String.Format("Finger = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Finger_Cost), PowerUpRates.Finger_CPS);
        }

        /// <summary>
        /// Update the Label for number of Grandmas owned
        /// </summary>
        public void UpdateGrandmaLabel()
        {
            this.lbGrandmas.Text = String.Format("Grandmas: {0}", CookieGame.GrandmasCount);
            this.btnBuyGrandma.Text = String.Format("Grandma = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Grandma_Cost), PowerUpRates.Grandma_CPS);
        }

        /// <summary>
        /// Update the Label for number of Robots owned
        /// </summary>
        public void UpdateRobotLabel()
        {
            this.lbRobots.Text = String.Format("Robots: {0}", CookieGame.RobotsCount);
            this.btnBuyRobot.Text = String.Format("Robot = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Robot_Cost), PowerUpRates.Robot_CPS);
        }

        // Gala code 


        public void updateFiveFingerButton()
        {
            this.btnFiveFinger.Text = String.Format("Five Fingers = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Finger_Cost * 5), PowerUpRates.Finger_CPS * 5);
        }

        public void updateFiveGrandmaButton()
        {
            this.btnFiveGrandmas.Text = String.Format("Five Grandmas = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Grandma_Cost * 5), PowerUpRates.Grandma_CPS * 5);
        }
        public void updateFiveRobotButton()
        {
            this.btnFiveRobots.Text = String.Format("Five Robots = {0:0} CPS: {1:0.00}", Math.Ceiling(PowerUpRates.Robot_Cost * 5), PowerUpRates.Robot_CPS * 5);
        }

        /// <summary>
        /// Update the Label for number of Cookies in inventory
        /// </summary>
        public void UpdateCookiesLabel()
        {
            this.lbCookies.Text = String.Format("Cookies: {0}", cookieGame.CookiesCount);

        }

        /// <summary>
        /// Update the Label for current Clicks Per Second
        /// </summary>
        public void UpdateCPSLabel()
        {
            this.lbCPS.Text = String.Format("Cookies Per Second: {0:0.0}", cookieGame.ClicksPerSecond);
        }

        /// <summary>
        /// Update All labels
        /// </summary>
        public void UpdateLabels()
        {
            this.UpdateCookiesLabel();
            this.UpdateCPSLabel();
            this.UpdateFingerLabel();
            this.UpdateGrandmaLabel();
            this.UpdateRobotLabel();
            this.updateFiveFingerButton();
            this.updateFiveGrandmaButton();
            this.updateFiveRobotButton();
        }

        /// <summary>
        /// Check Enabled Buttons, reset Labels, start Timer & select Game tab
        /// </summary>
        public void Start()
        {
            CheckEnabled();
            UpdateLabels();

            timeCookiePerSecond.Start();

            timerFall.Start();
            tabControl.SelectedTab = tabGame;
        }

        /// <summary>
        /// Close the Form
        /// <para>Calls this.Close()</para>
        /// </summary>
        public void Quit()
        {
            this.Close();
        }

        /// <summary>
        /// Check if current Cookie count in inventory is enough to purchase a PowerUp. Enable / Disable buttons as needed
        /// </summary>
        public void CheckEnabled()
        {
            //fixed
            if (cookieGame.CookiesCount < PowerUpRates.Grandma_Cost)
                btnBuyGrandma.Enabled = false;
            else
                btnBuyGrandma.Enabled = true;


            if (cookieGame.CookiesCount < PowerUpRates.Finger_Cost)
                btnBuyFinger.Enabled = false;
            else
                btnBuyFinger.Enabled = true;

            if (cookieGame.CookiesCount < PowerUpRates.Robot_Cost)
                btnBuyRobot.Enabled = false;
            else
                btnBuyRobot.Enabled = true;

            //gala

            if (cookieGame.CookiesCount < PowerUpRates.Finger_Cost * 5)
                btnFiveFinger.Enabled = false;
            else
                btnFiveFinger.Enabled = true;

            if (cookieGame.CookiesCount < PowerUpRates.Grandma_Cost * 5)
                btnFiveGrandmas.Enabled = false;
            else
                btnFiveGrandmas.Enabled = true;

            if (cookieGame.CookiesCount < PowerUpRates.Robot_Cost * 5)
                btnFiveRobots.Enabled = false;
            else
                btnFiveRobots.Enabled = true;
        }

        /// <summary>
        /// Increase CookieCount every second
        /// <para>Clicks Per Second timer with 1000ms interval</para>
        /// </summary>
        private void timeCookiePerSecond_Tick(object sender, EventArgs e)
        {

            cookieGame.UpdateCookies();
            UpdateLabels();
            CheckEnabled();

        }

        /// <summary>
        /// Add a Finger PowerUp
        /// </summary>
        public void AddFinger()
        {
            cookieGame.AddPowerUp(new Finger());
            UpdateLabels();
            CheckEnabled();
        }

        /// <summary>
        /// Add a Grandma PowerUp
        /// </summary>
        public void AddGrandma()
        {
            cookieGame.AddPowerUp(new Grandma());
            CheckEnabled();
            UpdateLabels();
        }

        /// <summary>
        /// Add a Robot PowerUp
        /// </summary>
        public void AddRobot()
        {
            cookieGame.AddPowerUp(new Robot());
            CheckEnabled();
            UpdateLabels();
        }

        public void AddFiveFinger()
        {
            cookieGame.AddPowerUp(new FiveFingers());
            UpdateLabels();
            CheckEnabled();
        }

        public void AddFiveGrandma()
        {
            cookieGame.AddPowerUp(new FiveGrandmas());
            UpdateLabels();
            CheckEnabled();
        }

        public void AddFiveRobot()
        {
            cookieGame.AddPowerUp(new FiveRobots());
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

        private void btnBuyFinger_Click(object sender, EventArgs e)
        {
            AddFinger();
        }

        private void btnBuyGrandma_Click(object sender, EventArgs e)
        {
            AddGrandma();
        }

        private void btnBuyRobot_Click(object sender, EventArgs e)
        {
            AddRobot();
        }
        private void BtnFiveFingers_Click(object sender, EventArgs e)
        {
            AddFiveFinger();

        }

        private void BtnFiveGrandmas_Click(object sender, EventArgs e)
        {
            AddFiveGrandma();

        }

        private void BtnFiveRobots_Click(object sender, EventArgs e)
        {
            AddFiveRobot();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(57, 89, 130));
            fallDoc.Draw(e.Graphics);

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
