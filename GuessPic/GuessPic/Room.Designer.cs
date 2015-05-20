namespace GuessPic
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.help_button = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.picGuess = new System.Windows.Forms.PictureBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.PictureBox();
            this.guessPic_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.help_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessPic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.Transparent;
            this.help_button.Image = global::GuessPic.Properties.Resources.guesspic_help;
            this.help_button.Location = new System.Drawing.Point(41, 470);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(97, 22);
            this.help_button.TabIndex = 6;
            this.help_button.TabStop = false;
            this.help_button.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.Image = global::GuessPic.Properties.Resources.guesspic_exit;
            this.exit_button.Location = new System.Drawing.Point(267, 470);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(98, 22);
            this.exit_button.TabIndex = 7;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(41, 226);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(324, 173);
            this.chatBox.TabIndex = 8;
            // 
            // picGuess
            // 
            this.picGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.picGuess.Image = global::GuessPic.Properties.Resources.guesspic_sample;
            this.picGuess.Location = new System.Drawing.Point(0, 58);
            this.picGuess.Name = "picGuess";
            this.picGuess.Size = new System.Drawing.Size(400, 156);
            this.picGuess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGuess.TabIndex = 9;
            this.picGuess.TabStop = false;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(41, 415);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(216, 20);
            this.sendTextBox.TabIndex = 10;
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.send_button.Image = ((System.Drawing.Image)(resources.GetObject("send_button.Image")));
            this.send_button.Location = new System.Drawing.Point(267, 417);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(99, 18);
            this.send_button.TabIndex = 11;
            this.send_button.TabStop = false;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // guessPic_logo
            // 
            this.guessPic_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(19)))));
            this.guessPic_logo.Image = global::GuessPic.Properties.Resources.guesspic_logo_tiny;
            this.guessPic_logo.Location = new System.Drawing.Point(0, 16);
            this.guessPic_logo.Name = "guessPic_logo";
            this.guessPic_logo.Size = new System.Drawing.Size(400, 32);
            this.guessPic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guessPic_logo.TabIndex = 12;
            this.guessPic_logo.TabStop = false;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuessPic.Properties.Resources.guesspic_bg1;
            this.ClientSize = new System.Drawing.Size(399, 496);
            this.ControlBox = false;
            this.Controls.Add(this.guessPic_logo);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.picGuess);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.help_button);
            this.FormBorderStyle = this.FormBorderStyle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 535);
            this.MinimizeBox = false;
            this.MinimumSize = this.MaximumSize;
            this.Name = "Room";
            this.Text = "GuessPic | New Room";
            ((System.ComponentModel.ISupportInitialize)(this.help_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessPic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox help_button;
        private System.Windows.Forms.PictureBox exit_button;

        #endregion
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.PictureBox picGuess;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.PictureBox send_button;
        private System.Windows.Forms.PictureBox guessPic_logo;
    }
}