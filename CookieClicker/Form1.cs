using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            timeCookiePerSecond.Start();
        }

        public void ClickCookie()
        {
            cookieGame.ClickCookie();
        }

        public void UpdateCookiesLabel()
        {
            this.lbCookies.Text = String.Format("Cookies: {0}", cookieGame.CookiesCount);

        }

        public void UpdateCPSLabel()
        {
            this.lbCPS.Text = String.Format("Cookies per second: {0}", cookieGame.ClicksPerSecond);
        }

        public void UpdateLabels()
        {
            this.UpdateCookiesLabel();
            this.UpdateCPSLabel();
        }

        private void btnCookieClick_Click(object sender, EventArgs e)
        {
            ClickCookie();
        }

        private void timeCookiePerSecond_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}
