namespace CookieClicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCookieClick = new System.Windows.Forms.Button();
            this.lbCookies = new System.Windows.Forms.Label();
            this.lbCPS = new System.Windows.Forms.Label();
            this.timeCookiePerSecond = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.btnBuyFinger = new System.Windows.Forms.Button();
            this.lbFingers = new System.Windows.Forms.Label();
            this.btnBuyGrandma = new System.Windows.Forms.Button();
            this.lbGrandmas = new System.Windows.Forms.Label();
            this.btnBuyRobot = new System.Windows.Forms.Button();
            this.lbRobots = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCookieClick
            // 
            this.btnCookieClick.Location = new System.Drawing.Point(111, 183);
            this.btnCookieClick.Name = "btnCookieClick";
            this.btnCookieClick.Size = new System.Drawing.Size(115, 45);
            this.btnCookieClick.TabIndex = 0;
            this.btnCookieClick.Text = "Cookie";
            this.btnCookieClick.UseVisualStyleBackColor = true;
            this.btnCookieClick.Click += new System.EventHandler(this.btnCookieClick_Click);
            // 
            // lbCookies
            // 
            this.lbCookies.AutoSize = true;
            this.lbCookies.Location = new System.Drawing.Point(108, 81);
            this.lbCookies.Name = "lbCookies";
            this.lbCookies.Size = new System.Drawing.Size(74, 17);
            this.lbCookies.TabIndex = 1;
            this.lbCookies.Text = "Cookies: 0";
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.Location = new System.Drawing.Point(108, 114);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(152, 17);
            this.lbCPS.TabIndex = 2;
            this.lbCPS.Text = "Cookies Per Second: 0";
            // 
            // timeCookiePerSecond
            // 
            this.timeCookiePerSecond.Interval = 1000;
            this.timeCookiePerSecond.Tick += new System.EventHandler(this.timeCookiePerSecond_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Controls.Add(this.tabGame);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(802, 477);
            this.tabControl.TabIndex = 3;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.btnLoad);
            this.tabMenu.Controls.Add(this.btnQuitGame);
            this.tabMenu.Controls.Add(this.btnStartGame);
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(794, 448);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(310, 209);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(142, 49);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Location = new System.Drawing.Point(310, 279);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(142, 49);
            this.btnQuitGame.TabIndex = 1;
            this.btnQuitGame.Text = "Quit";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(310, 144);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(142, 49);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.btnBuyRobot);
            this.tabGame.Controls.Add(this.lbRobots);
            this.tabGame.Controls.Add(this.btnBuyGrandma);
            this.tabGame.Controls.Add(this.lbGrandmas);
            this.tabGame.Controls.Add(this.btnBuyFinger);
            this.tabGame.Controls.Add(this.lbFingers);
            this.tabGame.Controls.Add(this.lbCPS);
            this.tabGame.Controls.Add(this.btnCookieClick);
            this.tabGame.Controls.Add(this.lbCookies);
            this.tabGame.Location = new System.Drawing.Point(4, 25);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(794, 448);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Game";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // btnBuyFinger
            // 
            this.btnBuyFinger.Location = new System.Drawing.Point(612, 81);
            this.btnBuyFinger.Name = "btnBuyFinger";
            this.btnBuyFinger.Size = new System.Drawing.Size(122, 31);
            this.btnBuyFinger.TabIndex = 4;
            this.btnBuyFinger.Text = "Finger = 10";
            this.btnBuyFinger.UseVisualStyleBackColor = true;
            this.btnBuyFinger.Click += new System.EventHandler(this.btnBuyFinger_Click);
            // 
            // lbFingers
            // 
            this.lbFingers.AutoSize = true;
            this.lbFingers.Location = new System.Drawing.Point(609, 61);
            this.lbFingers.Name = "lbFingers";
            this.lbFingers.Size = new System.Drawing.Size(71, 17);
            this.lbFingers.TabIndex = 3;
            this.lbFingers.Text = "Fingers: 0";
            // 
            // btnBuyGrandma
            // 
            this.btnBuyGrandma.Location = new System.Drawing.Point(612, 168);
            this.btnBuyGrandma.Name = "btnBuyGrandma";
            this.btnBuyGrandma.Size = new System.Drawing.Size(122, 31);
            this.btnBuyGrandma.TabIndex = 6;
            this.btnBuyGrandma.Text = "Grandma = 50";
            this.btnBuyGrandma.UseVisualStyleBackColor = true;
            this.btnBuyGrandma.Click += new System.EventHandler(this.btnBuyGrandma_Click);
            // 
            // lbGrandmas
            // 
            this.lbGrandmas.AutoSize = true;
            this.lbGrandmas.Location = new System.Drawing.Point(609, 148);
            this.lbGrandmas.Name = "lbGrandmas";
            this.lbGrandmas.Size = new System.Drawing.Size(90, 17);
            this.lbGrandmas.TabIndex = 5;
            this.lbGrandmas.Text = "Grandmas: 0";
            // 
            // btnBuyRobot
            // 
            this.btnBuyRobot.Location = new System.Drawing.Point(612, 258);
            this.btnBuyRobot.Name = "btnBuyRobot";
            this.btnBuyRobot.Size = new System.Drawing.Size(122, 31);
            this.btnBuyRobot.TabIndex = 8;
            this.btnBuyRobot.Text = "Robot = 200";
            this.btnBuyRobot.UseVisualStyleBackColor = true;
            // 
            // lbRobots
            // 
            this.lbRobots.AutoSize = true;
            this.lbRobots.Location = new System.Drawing.Point(609, 238);
            this.lbRobots.Name = "lbRobots";
            this.lbRobots.Size = new System.Drawing.Size(69, 17);
            this.lbRobots.TabIndex = 7;
            this.lbRobots.Text = "Robots: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCookieClick;
        private System.Windows.Forms.Label lbCookies;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Timer timeCookiePerSecond;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBuyFinger;
        private System.Windows.Forms.Label lbFingers;
        private System.Windows.Forms.Button btnBuyGrandma;
        private System.Windows.Forms.Label lbGrandmas;
        private System.Windows.Forms.Button btnBuyRobot;
        private System.Windows.Forms.Label lbRobots;
    }
}

