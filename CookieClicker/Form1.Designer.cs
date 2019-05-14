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
            this.SuspendLayout();
            // 
            // btnCookieClick
            // 
            this.btnCookieClick.Location = new System.Drawing.Point(119, 195);
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
            this.lbCookies.Location = new System.Drawing.Point(116, 44);
            this.lbCookies.Name = "lbCookies";
            this.lbCookies.Size = new System.Drawing.Size(74, 17);
            this.lbCookies.TabIndex = 1;
            this.lbCookies.Text = "Cookies: 0";
            // 
            // lbCPS
            // 
            this.lbCPS.AutoSize = true;
            this.lbCPS.Location = new System.Drawing.Point(116, 77);
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Size = new System.Drawing.Size(138, 17);
            this.lbCPS.TabIndex = 2;
            this.lbCPS.Text = "Clicks Per Second: 0";
            // 
            // timeCookiePerSecond
            // 
            this.timeCookiePerSecond.Enabled = true;
            this.timeCookiePerSecond.Interval = 1000;
            this.timeCookiePerSecond.Tick += new System.EventHandler(this.timeCookiePerSecond_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCPS);
            this.Controls.Add(this.lbCookies);
            this.Controls.Add(this.btnCookieClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCookieClick;
        private System.Windows.Forms.Label lbCookies;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Timer timeCookiePerSecond;
    }
}

