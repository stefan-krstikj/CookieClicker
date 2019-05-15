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
            this.lbCookies = new System.Windows.Forms.Label();
            this.lbCPS = new System.Windows.Forms.Label();
            this.timeCookiePerSecond = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.lbPlusCookie_1 = new System.Windows.Forms.Label();
            this.pbCookie = new System.Windows.Forms.PictureBox();
            this.btnBuyRobot = new System.Windows.Forms.Button();
            this.lbRobots = new System.Windows.Forms.Label();
            this.btnBuyGrandma = new System.Windows.Forms.Button();
            this.lbGrandmas = new System.Windows.Forms.Label();
            this.btnBuyFinger = new System.Windows.Forms.Button();
            this.lbFingers = new System.Windows.Forms.Label();
            this.timeLabelDisappear = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCookies
            // 
            this.lbCookies.AutoSize = true;
            this.lbCookies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCookies.Location = new System.Drawing.Point(81, 66);
            this.lbCookies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCookies.Name = "lbCookies";
            this.lbCookies.Size = new System.Drawing.Size(81, 16);
            this.lbCookies.TabIndex = 1;
            this.lbCookies.Text = "Cookies: 0";
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPS.Location = new System.Drawing.Point(81, 93);
            this.lbCPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(166, 16);
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
            this.tabControl.Location = new System.Drawing.Point(9, 10);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(602, 388);
            this.tabControl.TabIndex = 3;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.btnLoad);
            this.tabMenu.Controls.Add(this.btnQuitGame);
            this.tabMenu.Controls.Add(this.btnStartGame);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenu.Size = new System.Drawing.Size(594, 362);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(232, 170);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 40);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Location = new System.Drawing.Point(232, 227);
            this.btnQuitGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(106, 40);
            this.btnQuitGame.TabIndex = 1;
            this.btnQuitGame.Text = "Quit";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(232, 117);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(106, 40);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.lbPlusCookie_1);
            this.tabGame.Controls.Add(this.pbCookie);
            this.tabGame.Controls.Add(this.btnBuyRobot);
            this.tabGame.Controls.Add(this.lbRobots);
            this.tabGame.Controls.Add(this.btnBuyGrandma);
            this.tabGame.Controls.Add(this.lbGrandmas);
            this.tabGame.Controls.Add(this.btnBuyFinger);
            this.tabGame.Controls.Add(this.lbFingers);
            this.tabGame.Controls.Add(this.lbCPS);
            this.tabGame.Controls.Add(this.lbCookies);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabGame.Size = new System.Drawing.Size(594, 362);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Game";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // lbPlusCookie_1
            // 
            this.lbPlusCookie_1.AutoSize = true;
            this.lbPlusCookie_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlusCookie_1.Location = new System.Drawing.Point(99, 159);
            this.lbPlusCookie_1.Name = "lbPlusCookie_1";
            this.lbPlusCookie_1.Size = new System.Drawing.Size(75, 15);
            this.lbPlusCookie_1.TabIndex = 9;
            this.lbPlusCookie_1.Text = "+1 Cookie!";
            this.lbPlusCookie_1.Visible = false;
            this.lbPlusCookie_1.Click += new System.EventHandler(this.lbPlusCookie_Click);
            // 
            // pbCookie
            // 
            this.pbCookie.Location = new System.Drawing.Point(84, 136);
            this.pbCookie.Name = "pbCookie";
            this.pbCookie.Size = new System.Drawing.Size(185, 174);
            this.pbCookie.TabIndex = 12;
            this.pbCookie.TabStop = false;
            this.pbCookie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCookie_MouseDown);
            this.pbCookie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCookie_MouseUp);
            // 
            // btnBuyRobot
            // 
            this.btnBuyRobot.Location = new System.Drawing.Point(459, 210);
            this.btnBuyRobot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuyRobot.Name = "btnBuyRobot";
            this.btnBuyRobot.Size = new System.Drawing.Size(111, 36);
            this.btnBuyRobot.TabIndex = 8;
            this.btnBuyRobot.Text = "Robot = 200";
            this.btnBuyRobot.UseVisualStyleBackColor = true;
            this.btnBuyRobot.Click += new System.EventHandler(this.btnBuyRobot_Click);
            // 
            // lbRobots
            // 
            this.lbRobots.AutoSize = true;
            this.lbRobots.Location = new System.Drawing.Point(457, 193);
            this.lbRobots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRobots.Name = "lbRobots";
            this.lbRobots.Size = new System.Drawing.Size(53, 13);
            this.lbRobots.TabIndex = 7;
            this.lbRobots.Text = "Robots: 0";
            // 
            // btnBuyGrandma
            // 
            this.btnBuyGrandma.Location = new System.Drawing.Point(459, 136);
            this.btnBuyGrandma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuyGrandma.Name = "btnBuyGrandma";
            this.btnBuyGrandma.Size = new System.Drawing.Size(111, 38);
            this.btnBuyGrandma.TabIndex = 6;
            this.btnBuyGrandma.Text = "Grandma = 50";
            this.btnBuyGrandma.UseVisualStyleBackColor = true;
            this.btnBuyGrandma.Click += new System.EventHandler(this.btnBuyGrandma_Click);
            // 
            // lbGrandmas
            // 
            this.lbGrandmas.AutoSize = true;
            this.lbGrandmas.Location = new System.Drawing.Point(457, 120);
            this.lbGrandmas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGrandmas.Name = "lbGrandmas";
            this.lbGrandmas.Size = new System.Drawing.Size(67, 13);
            this.lbGrandmas.TabIndex = 5;
            this.lbGrandmas.Text = "Grandmas: 0";
            // 
            // btnBuyFinger
            // 
            this.btnBuyFinger.Location = new System.Drawing.Point(459, 66);
            this.btnBuyFinger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuyFinger.Name = "btnBuyFinger";
            this.btnBuyFinger.Size = new System.Drawing.Size(111, 43);
            this.btnBuyFinger.TabIndex = 4;
            this.btnBuyFinger.Text = "Finger = 10";
            this.btnBuyFinger.UseVisualStyleBackColor = true;
            this.btnBuyFinger.Click += new System.EventHandler(this.btnBuyFinger_Click);
            // 
            // lbFingers
            // 
            this.lbFingers.AutoSize = true;
            this.lbFingers.Location = new System.Drawing.Point(457, 50);
            this.lbFingers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFingers.Name = "lbFingers";
            this.lbFingers.Size = new System.Drawing.Size(53, 13);
            this.lbFingers.TabIndex = 3;
            this.lbFingers.Text = "Fingers: 0";
            // 
            // timeLabelDisappear
            // 
            this.timeLabelDisappear.Enabled = true;
            this.timeLabelDisappear.Interval = 350;
            this.timeLabelDisappear.Tick += new System.EventHandler(this.timeLabelDisappear_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 410);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCookie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label lbPlusCookie_1;
        private System.Windows.Forms.PictureBox pbCookie;
        private System.Windows.Forms.Timer timeLabelDisappear;
    }
}

