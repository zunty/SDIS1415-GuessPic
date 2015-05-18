namespace GuessPic
{
    partial class GuessPic
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
            this.help_button = new System.Windows.Forms.PictureBox();
            this.gp_login = new System.Windows.Forms.PictureBox();
            this.tw_login = new System.Windows.Forms.PictureBox();
            this.fb_login = new System.Windows.Forms.PictureBox();
            this.guesspic_logo = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.help_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tw_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guesspic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.help_button.BackColor = System.Drawing.Color.Transparent;
            this.help_button.Image = global::GuessPic.Properties.Resources.guesspic_help;
            this.help_button.Location = new System.Drawing.Point(41, 470);
            this.help_button.Name = "pictureBox7";
            this.help_button.Size = new System.Drawing.Size(97, 22);
            this.help_button.TabIndex = 6;
            this.help_button.TabStop = false;
            this.help_button.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // pictureBox6
            // 
            this.gp_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.gp_login.Image = global::GuessPic.Properties.Resources.guesspic_gp;
            this.gp_login.Location = new System.Drawing.Point(0, 342);
            this.gp_login.Name = "pictureBox6";
            this.gp_login.Size = new System.Drawing.Size(402, 72);
            this.gp_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gp_login.TabIndex = 5;
            this.gp_login.TabStop = false;
            // 
            // pictureBox5
            // 
            this.tw_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.tw_login.Image = global::GuessPic.Properties.Resources.guesspic_tw;
            this.tw_login.Location = new System.Drawing.Point(0, 264);
            this.tw_login.Name = "pictureBox5";
            this.tw_login.Size = new System.Drawing.Size(402, 72);
            this.tw_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tw_login.TabIndex = 4;
            this.tw_login.TabStop = false;
            // 
            // pictureBox4
            // 
            this.fb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.fb_login.Image = global::GuessPic.Properties.Resources.guesspic_fb;
            this.fb_login.Location = new System.Drawing.Point(0, 186);
            this.fb_login.Name = "pictureBox4";
            this.fb_login.Size = new System.Drawing.Size(402, 72);
            this.fb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fb_login.TabIndex = 3;
            this.fb_login.TabStop = false;
            // 
            // pictureBox3
            // 
            this.guesspic_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.guesspic_logo.Image = global::GuessPic.Properties.Resources.guesspic_logo;
            this.guesspic_logo.Location = new System.Drawing.Point(0, 23);
            this.guesspic_logo.Name = "pictureBox3";
            this.guesspic_logo.Size = new System.Drawing.Size(402, 112);
            this.guesspic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guesspic_logo.TabIndex = 2;
            this.guesspic_logo.TabStop = false;
            // 
            // pictureBox8
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.Image = global::GuessPic.Properties.Resources.guesspic_exit;
            this.exit_button.Location = new System.Drawing.Point(267, 470);
            this.exit_button.Name = "pictureBox8";
            this.exit_button.Size = new System.Drawing.Size(98, 22);
            this.exit_button.TabIndex = 7;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GuessPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuessPic.Properties.Resources.guesspic_bg1;
            this.ClientSize = new System.Drawing.Size(399, 496);
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.gp_login);
            this.Controls.Add(this.tw_login);
            this.Controls.Add(this.fb_login);
            this.Controls.Add(this.guesspic_logo);
            this.FormBorderStyle = this.FormBorderStyle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 535);
            this.MinimizeBox = false;
            this.MinimumSize = this.MaximumSize;
            this.Name = "GuessPic";
            this.Text = "GuessPic";
            ((System.ComponentModel.ISupportInitialize)(this.help_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gp_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tw_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guesspic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox guesspic_logo;
        private System.Windows.Forms.PictureBox fb_login;
        private System.Windows.Forms.PictureBox tw_login;
        private System.Windows.Forms.PictureBox gp_login;
        private System.Windows.Forms.PictureBox help_button;
        private System.Windows.Forms.PictureBox exit_button;

    }
}

